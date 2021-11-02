using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// created date: 02/11/21
    /// created by: vxkhanh
    /// </summary>
    public interface ICartRepository:IBaseRepository
    {
        /// <summary>
        /// Hàm lấy danh sách giỏ hàng theo id khách hàng
        /// </summary>
        /// <param name="customerId">id khách hàng</param>
        /// <returns>List cart</returns>
        public IEnumerable<Cart> getCartsByCustomer(Guid customerId);
    }
}
