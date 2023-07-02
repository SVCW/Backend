using Microsoft.EntityFrameworkCore;
using SVCW.DTOs.Users;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Services
{
	public class UserService : IUser
	{
        private readonly SVCWContext _context;

        public UserService(SVCWContext context)
        {
            _context = context;
        }

        public async Task<CreateUserDTO> createUser(CreateUserDTO newUser)
        {
            try
            {
                var user = new User();

                user.UserId = "USR" + Guid.NewGuid().ToString().Substring(0, 7);
                //maping
                user.Email = newUser.Email;
                user.FullName = newUser.FullName ?? "none";
                user.Username = newUser.Email;
                user.Password = newUser.Password ?? "PWD" + Guid.NewGuid().ToString().Substring(0, 7);
                user.Phone = newUser.Phone ?? "none";
                user.Gender = newUser.Gender ?? true;
                user.DateOfBirth = newUser.DateOfBirth;
                user.Image = newUser.Image ?? "none";
                user.CreateAt = newUser.CreateAt ?? DateTime.Now;

                // build data return
                newUser.FullName = user.FullName;
                newUser.Phone = user.Phone;
                newUser.Gender = user.Gender;
                newUser.Image = user.Image;
                newUser.CreateAt = user.CreateAt;

                user.Status = newUser.Status ?? user.Status;
                user.RoleId = newUser.RoleId ?? "role1";

                await this._context.User.AddAsync(user);
                await this._context.SaveChangesAsync();
                return newUser;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public async Task<LoginUserDTO> validateLoginUser(LoginUserDTO loginUser)
        {
            try
            {
                var loginResultData = new LoginUserDTO();

                var usrEmail = loginUser.Email;
                if (!isValidEmail(usrEmail))
                {
                    loginResultData.resultCode = "Invalid Email";
                    loginResultData.resultMsg = "Invalid Email! Email domain must in intergrated list";
                    return loginResultData;
                }

                var user = await this._context.User.Where(x => x.Email.Equals(usrEmail)).FirstOrDefaultAsync();

                if (user == null)
                {
                    loginResultData.resultCode = "FirstT Login";
                    loginResultData.resultMsg = "Do createUser for first time";
                    return loginResultData;
                }

                loginResultData.UserId = user.UserId;
                loginResultData.Email = user.Email;
                loginResultData.Username = user.Username;
                loginResultData.FullName = user.FullName;
                loginResultData.Phone = user.Phone;
                loginResultData.Gender = user.Gender;
                loginResultData.Image = user.Image;
                loginResultData.DateOfBirth = user.DateOfBirth;
                loginResultData.CreateAt = user.CreateAt;
                loginResultData.Status = user.Status;
                loginResultData.RoleId = user.RoleId;

                loginResultData.resultCode = "SUCCESS";
                loginResultData.resultMsg = "Login SUCCESS";

                return loginResultData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool isValidEmail(string usrEmail)
        {
            // Hiện tại đang set cứng, sau này phải check trong list domain của các trường mình đã intergrate
            return usrEmail.Split('@')[1].Equals("fpt.edu.vn");
        }

        public async Task<UpdateUserDTO> updateUser(UpdateUserDTO updateUser)
        {
            try
            {
                var user = await this._context.User.Where(x => x.UserId.Equals(updateUser.UserId)).FirstOrDefaultAsync();

                if (user != null)
                {
                    user.Username = updateUser.Username ?? user.Username;
                    user.Password = updateUser.Password ?? user.Password;
                    user.FullName = updateUser.FullName ?? user.FullName;
                    user.Phone = updateUser.Phone ?? user.Phone;
                    user.Status = updateUser.Status ?? user.Status;
                    user.Gender = updateUser.Gender ?? user.Gender;
                    user.Image = updateUser.Image ?? user.Image;
                    user.DateOfBirth = updateUser.DateOfBirth ?? user.DateOfBirth;
                    user.Status = updateUser.Status ?? user.Status;
                    user.RoleId = updateUser.RoleId ?? user.RoleId;
                    await this._context.SaveChangesAsync();
                }
                return updateUser;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<User>> getAllUser()
        {
            try
            {
                var users = await this._context.User.ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

