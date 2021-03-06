using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// Lớp điều khiển cho store
    /// </summary>
    [Route("api/v1.0/categories")]
    [ApiController]
    public class CategoryController : BaseController<Category>
    {
        ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService) : base(_categoryService)
        {
            categoryService = _categoryService;
        }
    }
}
