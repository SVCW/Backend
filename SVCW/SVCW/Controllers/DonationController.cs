using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVCW.DTOs;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private IDonation service;
        public DonationController(IDonation service)
        {
            this.service = service;
        }

        [Route("get-Donation")]
        [HttpGet]
        public async Task<IActionResult> getall()
        {
            ResponseAPI<List<Donation>> responseAPI = new ResponseAPI<List<Donation>>();
            try
            {
                responseAPI.Data = await this.service.GetDonation();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("get-Donation-activity")]
        [HttpGet]
        public async Task<IActionResult> getDonationActivity(string id)
        {
            ResponseAPI<List<Donation>> responseAPI = new ResponseAPI<List<Donation>>();
            try
            {
                responseAPI.Data = await this.service.GetDonationsActivity(id);
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
