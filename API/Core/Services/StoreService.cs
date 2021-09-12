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
    public class StoreService: BaseService, IStoreService
    {
        IStoreRepository storeRepository;
        public StoreService(IStoreRepository _storeRepository) : base(_storeRepository)
        {
            storeRepository = _storeRepository;
        }
    }
}
