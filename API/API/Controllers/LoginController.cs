using Core.Interfaces;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// created date: 04/11/2021
    /// created by: vxkhanh
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        ILoginService loginService;
        public LoginController(ILoginService _loginService)
        {
            loginService = _loginService;
        }

        /// <summary>
        /// Hàm kiểm tra đăng nhập của khách hàng
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult login(string username, string password)
        {
            ServiceResult result = loginService.login(username, password);
            if (result.code == statusCode.success)
                return StatusCode(200, result);
            else if (result.code == statusCode.noContent)
                return StatusCode(204, result);
            else
                return StatusCode(500, result);
        }
    }
}
