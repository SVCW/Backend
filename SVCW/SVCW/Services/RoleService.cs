using SVCW.DTOs.Roles;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Services
{
    public class RoleService : IRole
    {
        private readonly SVCWContext _context;
        public RoleService(SVCWContext context)
        {
            _context = context;
        }
        public async Task<Role> create(RoleCreateDTO role)
        {
            try
            {
                var rle = new Role();
                rle.Description = role.Description;
                rle.RoleName = role.RoleName;
                rle.RoleId = "ROLE" + Guid.NewGuid().ToString().Substring(0,6);
                rle.Status = true;

                await this._context.Role.AddAsync(rle);
                if(await this._context.SaveChangesAsync() > 0)
                {
                    return rle;
                }
                else
                {
                    throw new Exception("Save DB Fail");
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<Role> delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Role> findById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Role>> findByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Role>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<Role> update(RoleUpdateDTO role)
        {
            throw new NotImplementedException();
        }
    }
}
