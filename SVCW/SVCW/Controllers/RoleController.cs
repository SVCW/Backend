using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVCW.DTOs.Roles;
using SVCW.DTOs;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRole service;
        public RoleController(IRole service)
        {
            this.service = service;
        }

        [Route("Insert-Category")]
        [HttpPost]
        public async Task<IActionResult> Insert(RoleCreateDTO dto)
        {
            ResponseAPI<List<Role>> responseAPI = new ResponseAPI<List<Role>>();
            try
            {
                responseAPI.Data = await this.service.create(dto);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
    }
}
