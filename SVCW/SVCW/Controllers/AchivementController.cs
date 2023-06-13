using Microsoft.AspNetCore.Mvc;
using SVCW.DTOs;
using SVCW.DTOs.Achivements;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AchivementController : ControllerBase
    {
        private IAchivement _achivementService;
        public AchivementController(IAchivement achivementService)
        {
            this._achivementService = achivementService;
        }
        [Route("get-all-achivement")]
        [HttpGet]
        public async Task<IActionResult> GetAllAchivement()
        {

            ResponseAPI<List<Achivement>> responseAPI = new ResponseAPI<List<Achivement>>();
            try
            {
                responseAPI.Data = await this._achivementService.GetAllAchivements();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("get-achivement-by-id")]
        [HttpGet]
        public async Task<IActionResult> GetAchivementById(string? achivementId)
        {

            ResponseAPI<List<Achivement>> responseAPI = new ResponseAPI<List<Achivement>>();
            try
            {
                responseAPI.Data = await this._achivementService.GetAchivementById(achivementId);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("insert-achivement")]
        [HttpPost]
        public async Task<IActionResult> InsertFood(AchivementDTO achivementId)
        {
            ResponseAPI<List<AchivementDTO>> responseAPI = new ResponseAPI<List<AchivementDTO>>();
            try
            {
                responseAPI.Data = await this._achivementService.InsertAchivement(achivementId);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("update-achivement-by-id")]
        [HttpPut]
        public async Task<IActionResult> UpdateAchivement(AchivementDTO upAchivement)
        {
            ResponseAPI<List<Achivement>> responseAPI = new ResponseAPI<List<Achivement>>();
            try
            {
                responseAPI.Data = await this._achivementService.UpdateAchivement(upAchivement);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-achivement-by-id")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFood([FromQuery] List<string> achivementId)
        {
            ResponseAPI<List<Achivement>> responseAPI = new ResponseAPI<List<Achivement>>();
            try
            {
                responseAPI.Data = await this._achivementService.DeleteAchivement(achivementId);
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
