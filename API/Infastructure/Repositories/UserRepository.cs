using Core.Interfaces;
using Core.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Infastructure.Repositories
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public class UserRepository : BaseRepository, IUserRepository
    {
        public User getUser(string username, string password)
        {
            string procName = $"procGetUser";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@username", username);
            dynamicParameters.Add($"@password", password);
            User result = dbConnection.Query<User>(procName, param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return result;
        }
    }
}
