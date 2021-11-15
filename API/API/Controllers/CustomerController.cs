using Core.Interfaces;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web.Helpers;

namespace API.Controllers
{
    /// <summary>
    /// created date: 29/06/2021
    /// created by: VXKHANH
    /// Lớp điều khiển cho Customer
    /// </summary>
    public class CustomerController : BaseController<Customer>
    {
        ICustomerService customerService;
        public CustomerController(ICustomerService _customerService): base(_customerService)
        {
            customerService = _customerService;
        }

        /// <summary>
        /// created date: 11/08/2021
        /// created by: VXKHANH
        /// Thêm thông tin khách hàng mới với mật khẩu được mã hóa sha256
        /// </summary>
        [HttpPost]
        public override IActionResult post(Customer papram)
        {
            try
            {
                papram.password = Crypto.SHA256(papram.password).ToUpper();
                return base.post(papram);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

    }
}
