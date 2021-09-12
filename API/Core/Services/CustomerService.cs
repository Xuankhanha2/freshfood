﻿using Core.Interfaces;
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
    }
}
