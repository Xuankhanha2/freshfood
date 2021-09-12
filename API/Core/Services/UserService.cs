using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    /// <summary>
    /// Created date: 20/7/2021
    /// Created by: VXKHANH
    /// </summary>
    public class UserService : BaseService, IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository _userRepository) : base(_userRepository)
        {
            userRepository = _userRepository;
        }
    }
}
