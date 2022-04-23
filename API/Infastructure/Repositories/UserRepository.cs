using Core.Interfaces;
using Core.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
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
            SHA256Managed crypto = new SHA256Managed();
            string cryptoPassword = base.sha256Hash(password);
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@username", username);
            dynamicParameters.Add($"@password", cryptoPassword);
            User result = dbConnection.Query<User>(procName, param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return result;
        }
    }
}
