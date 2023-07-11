using SVCW.DTOs.Users;
using SVCW.Models;

namespace SVCW.Interfaces
{
    public interface IUser
    {
        Task<List<User>> getAllUser();
        Task<CreateUserDTO> createUser(CreateUserDTO newUser);
        Task<LoginUserDTO> validateLoginUser(LoginUserDTO loginUser);
        Task<UpdateUserDTO> updateUser(UpdateUserDTO updateUser);
    }
}
