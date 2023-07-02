using Microsoft.AspNetCore.Mvc;
using SVCW.DTOs;
using SVCW.DTOs.Comments;
using SVCW.DTOs.Users;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
	{
        private IUser service;
        public UserController(IUser service)
        {
            this.service = service;
        }

        [Route("get-all-user")]
        [HttpGet]
        public async Task<IActionResult> getAllUser()
        {
            ResponseAPI<List<User>> responseAPI = new ResponseAPI<List<User>>();
            try
            {
                responseAPI.Data = await this.service.getAllUser();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("validate-login-user")]
        [HttpPost]
        public async Task<IActionResult> validateLoginUser(LoginUserDTO loginUser)
        {
            ResponseAPI<LoginUserDTO> responseAPI = new ResponseAPI<LoginUserDTO>();
            try
            {
                var dataResponse = new LoginUserDTO();

                var loginResultData = await this.service.validateLoginUser(loginUser);
                var rstCode = loginResultData.resultCode;
                Console.WriteLine(rstCode + " - " + loginResultData.resultMsg);

                if (rstCode.Equals("FirstT Login"))
                {
                    var newUser = (CreateUserDTO) loginUser;

                    // Create user for the first time
                    Console.WriteLine("Do create new User...");
                    var createUserResult = await this.service.createUser(newUser);

                    if (!createUserResult.resultCode.Equals("SUCCESS"))
                    {
                        dataResponse.resultCode = "New User Failed";
                        dataResponse.resultMsg = "Valid User login Info. But create new user Fail";
                        responseAPI.Data = dataResponse;
                        return Ok(responseAPI);
                    }
                    dataResponse.resultCode = "SUCCESS";
                    dataResponse.resultMsg = "Valid Login Info. New user was created!";
                    responseAPI.Data = dataResponse;
                    return Ok(responseAPI);
                }

                dataResponse = loginResultData;
                responseAPI.Data = dataResponse;
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("create-user")]
        [HttpPost]
        public async Task<IActionResult> createUser(CreateUserDTO newUser)
        {
            ResponseAPI<CreateUserDTO> responseAPI = new ResponseAPI<CreateUserDTO>();
            try
            {
                responseAPI.Data = await this.service.createUser(newUser);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("update-user")]
        [HttpPut]
        public async Task<IActionResult> updateUser(UpdateUserDTO updateUser)
        {
            ResponseAPI<User> responseAPI = new ResponseAPI<User>();
            try
            {
                responseAPI.Data = await this.service.updateUser(updateUser);
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

