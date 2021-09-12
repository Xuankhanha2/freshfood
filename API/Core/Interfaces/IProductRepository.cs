﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public interface IProductRepository:IBaseRepository
    {
        /// <summary>
        /// created date: 8/9/2021
        /// Hàm lấy danh sách sản phẩm được sắp xếp theo tiêu chí được truyền vào
        /// </summary>
        /// <param name="order">Tiêu chí sắp xếp</param>
        /// <returns></returns>
        public IEnumerable<Product> getOrderProduct(string order);

        /// <summary>
        /// created date: 8/9/2021
        /// created by: vux xuan khanh
        /// Hàm lấy danh sách sản phẩm được sắp xếp the tiêu chí dược truyền vào và được lọc theo danh mục sản phẩm 
        /// </summary>
        /// <param name="categoryId">id của anh mục</param>
        /// <param name="order">Tiêu chí sắp xếp</param>
        /// <returns></returns>
        public IEnumerable<Product> getOrderProduct(Guid categoryId, string order);
    }
}
