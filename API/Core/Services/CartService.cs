using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    /// <summary>
    /// created date: 02/11/21
    /// created by: vxkhanh
    /// </summary>
    public class CartService:BaseService, ICartService
    {
        ICartRepository cartRepository;
        public CartService(ICartRepository _cartRepository):base(_cartRepository)
        {
            cartRepository = _cartRepository;
        }
        /// <summary>
        /// Hàm lấy danh sách sản phẩm trong giỏ hàng theo mã khách hàng
        /// </summary>
        /// <param name="customerId">id khách hàng</param>
        /// <returns>service result</returns>
        public ServiceResult getCartsByCustomerId(Guid customerId)
        {
            try
            {
                var list = cartRepository.getCartsByCustomer(customerId);
                if (list != null)
                {
                    serviceResult.isValid = true;
                    serviceResult.data = list;
                    serviceResult.code = statusCode.success;
                }
                else
                {
                    serviceResult.isValid = true;
                    serviceResult.data = list;
                    serviceResult.code = statusCode.noContent;
                }
            }
            catch (Exception e)
            {
                serviceResult.isValid = false;
                serviceResult.data = null;
                serviceResult.message = e.Message;
                serviceResult.code = statusCode.exception;
            }
            return serviceResult;
        }
    }
}
