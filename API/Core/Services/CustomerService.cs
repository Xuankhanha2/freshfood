using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public class CustomerService:BaseService , ICustomerService
    {
        ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository _customerRepository) : base(_customerRepository)
        {
            customerRepository = _customerRepository;
        }

        public ServiceResult customerLogin(string username, string password)
        {
            try
            {
                Customer customer = customerRepository.customerLogin(username, password);
                if (customer != null)
                {
                    serviceResult.data = customer;
                    serviceResult.code = statusCode.success;
                    serviceResult.message = "success";
                }
                else
                {
                    serviceResult.code = statusCode.noContent;
                    serviceResult.data = null;
                    serviceResult.message = "fail";
                }
            }
            catch (Exception e)
            {
                serviceResult.code = statusCode.exception;
                serviceResult.message = e.Message;
                serviceResult.data = null;
            }
            return serviceResult;
        }
    }
}
