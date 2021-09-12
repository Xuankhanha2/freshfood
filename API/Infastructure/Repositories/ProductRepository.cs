using Core.Interfaces;
using Core.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Infastructure.Repositories
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public class ProductRepository:BaseRepository, IProductRepository
    {
        
        /// <summary>
        /// created date: 8/9/2021
        /// created by: vx xuan khanh
        /// Hàm lấy danh sách sản phẩm được sắp xếp theo tiêu chí được truyền vào
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public IEnumerable<Product> getOrderProduct(string order)
        {
            string procName = "";
            switch (order) {
                case "name_a_z":
                    procName = "procGetProductOrderByNameASC";
                    break;
                case "name_z_a":
                    procName = "procGetProductOrderByNameDESC";
                    break;
                case "price_increase":
                    procName = "procGetProductOrderByPriceASC";
                    break;
                case "price_decrease":
                    procName = "procGetProductOrderByPriceDESC";
                    break;
            }
            var products = dbConnection.Query<Product>(procName, commandType: CommandType.StoredProcedure);
            return products;

        }

        /// <summary>
        /// created date: 8/9/2021
        /// created by: vux xuan khanh
        /// Hàm lấy danh sách sản phẩm được sắp xếp the tiêu chí dược truyền vào và được lọc theo danh mục sản phẩm 
        /// </summary>
        /// <param name="categoryId">id của anh mục</param>
        /// <param name="order">Tiêu chí sắp xếp</param>
        /// <returns></returns>
        public IEnumerable<Product> getOrderProduct(Guid categoryId, string order)
        {
            return null;
        }
    }

}
