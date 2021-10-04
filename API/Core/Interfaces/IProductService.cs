using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public interface IProductService:IBaseService
    {
        /// <summary>
        /// Service lấy danh sách sản phẩm đã được sắp xếp
        /// </summary>
        /// <param name="order">Tiêu chí sắp xếp</param>
        /// <returns>Danh sách sản phẩm đã được sắp xếp</returns>
        public ServiceResult getOrderedProduct(string order);
    }
}
