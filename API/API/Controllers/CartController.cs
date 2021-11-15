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
    /// created date: 02/11/21
    /// created by: vxkhanh
    /// </summary>
    public class CartController : BaseController<Cart>
    {
        ICartService cartService;
        public CartController(ICartService _cartService): base(_cartService)
        {
            cartService = _cartService;
        }

        /// <summary>
        /// created date: 02/11/2021
        /// created by: vxkhanh
        /// Hàm điều khiển - lấy danh sách giỏ hàng theo id khách hàng
        /// </summary>
        /// <param name="customerId">id khách hàng</param>
        /// <returns>Service result</returns>
        [HttpGet("customerId/{customerId}")]
        public IActionResult getCartsByCustomerId(Guid customerId)
        {
            ServiceResult result = cartService.getCartsByCustomerId(customerId);
            if (result.code == statusCode.exception)
                return StatusCode(500, result);
            if (result.code == statusCode.success)
                return StatusCode(200, result.data);
            else
                return StatusCode(204, result.data);
        }
    }
}
