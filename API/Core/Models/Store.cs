using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    /// <summary>
    /// created date: 18/07/2021
    /// created by: VXKHANH
    /// Lớp cửa hàng/ nhà sản xuất sản phẩm
    /// </summary>
    public class Store : BaseClass
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        [required, duplicate]
        public Guid storeId { get; set; }

        /// <summary>
        /// tên của hàng/ Nhà cung cấp
        /// </summary>
        [required]
        public string storeName { get; set; }

    }
}
