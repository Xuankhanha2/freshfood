using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// created date: 29/06/2021
    /// created by: VXKHANH
    /// Lớp điều khiển cho Customer
    /// </summary>
    public class CustomerController : BaseController<Customer>
    {
        ICustomerService customerService;
        public CustomerController(ICustomerService _customerService): base(_customerService)
        {
            customerService = _customerService;
        }
    }
}
