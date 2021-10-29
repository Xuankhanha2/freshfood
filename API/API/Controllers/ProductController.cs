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
        public ProductController(IProductService _productService) : base(_productService)
        {
            productService = _productService;
        }

        [HttpGet("order/{order}")]
        public IActionResult Get(string order)
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
    }
}
