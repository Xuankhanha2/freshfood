﻿using Core.Interfaces;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Controllers
{
    /// <summary>
    /// created date: 20/06/2021
    /// created by: VXKHANH
    /// Lớp controller base chung
    /// </summary>
    [Route("api/v1.0/[controller]s")]
    [ApiController]
    public class BaseController<entity> : ControllerBase
    {
        IBaseService baseService;
        public BaseController(IBaseService _baseService)
        {
            baseService = _baseService;
        }
        // GET: api/<BaseController>
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Trả về toàn bộ các bản ghi
        /// </summary>
        /// <typeparam name="entity"></typeparam>
        /// <returns>Danh sách các bản ghi</returns>
        [HttpGet()]
        public IActionResult getAll()
        {
            ServiceResult result = baseService.getAll<entity>();
            if (result.code == statusCode.exception)
                return StatusCode(500, result);
            if (result.code == statusCode.success)
                return StatusCode(200, result.data);
            else
                return StatusCode(204, result.data);
        }

        // GET api/<BaseController>/5
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Trả về bản ghi theo Id truyền vào
        /// </summary>
        /// <typeparam name="entity"></typeparam>
        [HttpGet("{id}")]
        public IActionResult getById(Guid id)
        {
            ServiceResult result = baseService.getById<entity>(id);
            if (result.code == statusCode.exception)
                return StatusCode(500, result);
            if (result.code == statusCode.success)
                return StatusCode(200, result.data);
            else
                return StatusCode(204, result.data);
        }

        // POST api/<BaseController>
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Thêm bản ghi mới với dữ liệu được láy từ bodyRequest
        /// </summary>
        [HttpPost]
        public IActionResult post(entity papram)
        {
            ServiceResult result = baseService.insert<entity>(papram);
            if (result.code == statusCode.exception)
                return StatusCode(500, result);
            if (result.code == statusCode.success)
                return StatusCode(201, result);
            if (result.code == statusCode.fail)
                return StatusCode(200, result);
            else
                return StatusCode(400, result);
        }

        // PUT api/<BaseController>/5
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Sửa bản ghi với dữ liêu được lấy tử bodyRequest
        /// </summary>
        /// <param name="id">Id</param>
        [HttpPut()]
        public IActionResult put(entity papram)
        {
            ServiceResult result = baseService.update<entity>(papram);
            if (result.code == statusCode.exception)
                return StatusCode(500, result);
            if (result.code == statusCode.success)
                return StatusCode(201, result);
            if (result.code == statusCode.fail)
                return StatusCode(200, result);
            else
                return StatusCode(400, result);
        }

        // DELETE api/<BaseController>/5
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Xóa 1 bản ghi theo id được truyền vào
        /// </summary>
        /// <param name="id">Id</param>
        [HttpDelete("{id}")]
        public IActionResult delete(Guid id)
        {
            ServiceResult result = baseService.delete<entity>(id);
            if (result.code == statusCode.success)
                return StatusCode(200, result);
            if (result.code == statusCode.fail)
                return StatusCode(400, result);
            else
                return StatusCode(500, result);
        }
    }
}
