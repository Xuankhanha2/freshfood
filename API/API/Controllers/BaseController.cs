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
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // GET: api/<BaseController>
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Trả về toàn bộ các bản ghi
        /// </summary>
        /// <typeparam name="entity"></typeparam>
        /// <returns>Danh sách các bản ghi</returns>
        [HttpGet]
        public IEnumerable<entity> Get<entity>()
        {
            return null;
        }

        // GET api/<BaseController>/5
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Trả về bản ghi theo Id truyền vào
        /// </summary>
        /// <typeparam name="entity"></typeparam>
        [HttpGet("{id}")]
        public void Get<entity>(int id)
        {
          
        }

        // POST api/<BaseController>
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Thêm bản ghi mới với dữ liệu được láy từ bodyRequest
        /// </summary>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BaseController>/5
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Sửa bản ghi với dữ liêu được lấy tử bodyRequest
        /// </summary>
        /// <param name="id">Id</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BaseController>/5
        /// <summary>
        /// created date: 20/06/2021
        /// created by: VXKHANH
        /// Xóa 1 bản ghi theo id được truyền vào
        /// </summary>
        /// <param name="id">Id</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
