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
        public IEnumerable<Product> getOrderedProduct(string order)
        {
            //Câu lệnh sql mẫu
            string sql = "SELECT p.productId," +
                            " p.productName," +
                            " p.categoryId," +
                            " p.price," +
                            " p.discount," +
                            " p.hot," +
                            " p.image," +
                            " p.description," +
                            " p.storeId," +
                            " p.createdDate," +
                            " p.createdBy," +
                            " p.modifiedDate," +
                            " p.status FROM product p ORDER BY";
            //Thêm tiêu chí đánh giá vào câu lệnh sql
            if (order.Equals("name_a_z"))
            {
                //theo tên từ a-z
                sql += " p.productName ASC;";
            }
            else if(order.Equals("name_z_a"))
            {
                //theo tên từ z-a
                sql += " p.productName DESC;";
            }else if (order.Equals("price_increase"))
            {
                //theo giá tăng dần
                sql += " p.price ASC;";
            }else if (order.Equals("price_decrease"))
            {
                //theo giá giảm dần
                sql += " p.price DESC;";
            }
            else
            {
                //mặc định sắp xếp theo ngày tạo mới nhất
                sql += " p.createdDate DESC;";
            }
            //Lấy danh sách sản phẩm từ db
            var products = dbConnection.Query<Product>(sql, commandType: CommandType.Text);
            //trả về danh sách sản phẩm
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
        public IEnumerable<Product> getOrderedProduct(Guid categoryId, string order)
        {
            return null;
        }
    }

}
