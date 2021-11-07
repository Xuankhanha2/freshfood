using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Linq;

namespace Infastructure.Repositories
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public Customer customerLogin(string username, string password)
        {
            string procName = "procCustomerLogin";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("username", username);
            dynamicParameters.Add("password", password);
            Customer customer = dbConnection.Query<Customer>(procName, param: dynamicParameters, commandType:CommandType.StoredProcedure).FirstOrDefault();
            return customer;
        }
    }
}
