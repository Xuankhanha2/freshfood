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
    /// Created date: 17/07/2021
    /// Created by: VXKHANH
    /// </summary>
    public class ProductController : BaseController<Product>
    {
        IProductService productService;
        public ProductController(IProductService _productService): base(_productService)
        {
            productService = _productService;
        }

        /// <summary>
        /// created by: vxkhanh
        /// created date: 12/11/2021
        /// Hàm lấy danh sách sản phẩm đã sắp xếp 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpGet("order/{order}")]
        public IActionResult getCustomerOrderBy(string order)
        {
            ServiceResult result = productService.getOrderedProduct(order);
            if(result.code == statusCode.success || result.code == statusCode.noContent)
            {
                return StatusCode(200, result.data);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpGet("categoryId/{categoryId}")]
        public IActionResult getProductsByCategory(Guid categoryId)
        {
            ServiceResult result = productService.getProductsByCategory(categoryId);
            if (result.code == statusCode.success)
            {
                return StatusCode(200, result.data);
            }
            else if (result.code == statusCode.noContent)
            {
                return StatusCode(204, result.data);
            }
            else
            {
                return StatusCode(500, result);
            }
        }
    }
}
