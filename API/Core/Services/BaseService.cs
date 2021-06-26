using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Models.BaseClass;

namespace Core.Services
{
    class BaseService : IBaseService
    {
        /// <summary>
        /// created date: 23/06/2021
        /// created by: VXKHANH
        /// </summary>
        ServiceResult serviceResult = new ServiceResult();
        IBaseRepository baseRepository;
        public BaseService(IBaseRepository _baseRepository)
        {
            baseRepository = _baseRepository;
        }
       
        /// <summary>
        /// created date: 23/06/2021
        /// created by: VXKHANH
        /// Lấy toàn bộ dữ liệu 
        /// </summary>
        /// <returns>Danh sách dữ liệu</returns>
        public ServiceResult getAll<entity>()
        {
            try
            {
                var list = baseRepository.GetAll<entity>();
                if (list != null)
                {
                    serviceResult.isValid = true;
                    serviceResult.data = list;
                    serviceResult.message = "Success";
                    serviceResult.code = statusCode.success;
                }
                else
                {
                    serviceResult.isValid = true;
                    serviceResult.data = list;
                    serviceResult.message = "No content";
                    serviceResult.code = statusCode.noContent;
                }
            }
            catch (Exception e)
            {
                serviceResult.isValid = false;
                serviceResult.data = null;
                serviceResult.message = "Fail";
                serviceResult.code = statusCode.exception;
            }
            return serviceResult;
        }

        public ServiceResult getById<entity>(Guid id)
        {
            try
            {
                var data = baseRepository.getById<entity>(id);
                if (data != null)
                {
                    serviceResult.isValid = true;
                    serviceResult.data = data;
                    serviceResult.message = "Success";
                    serviceResult.code = statusCode.success;
                }
                else
                {
                    serviceResult.isValid = true;
                    serviceResult.data = data;
                    serviceResult.message = "No content";
                    serviceResult.code = statusCode.noContent;
                }
            }
            catch (Exception e)
            {
                serviceResult.isValid = false;
                serviceResult.data = null;
                serviceResult.message = "Fail";
                serviceResult.code = statusCode.exception;
            }
            return serviceResult;
        }

        public ServiceResult insert<entity>(entity param)
        {
            try
            {
                int check = baseRepository.insertEntity<entity>(param);
                if(check > 0)
                {

                }
            }
            catch(Exception e)
            {

            }
            return serviceResult;
        }

        public ServiceResult update<entity>(entity param)
        {
            throw new NotImplementedException();
        }

        public ServiceResult delete<entity>(Guid id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult baseValidate<entity>(entity data)
        {
            serviceResult.isValid = true;
            var listError = new List<string>();

            var properties = data.GetType().GetProperties();
            foreach(var property in properties)
            {
                string propertyName = property.Name;
                var propertyValue = property.GetValue(data);
                if (property.IsDefined(typeof(required), false))
                {
                    
                    if(propertyValue == null || propertyValue.ToString().Equals(""))
                    {
                        serviceResult.isValid = false;
                        listError.Add(propertyName + "is required!");
                        serviceResult.code = statusCode.notValid;
                    }
                }
                if(property.IsDefined(typeof(duplicate), false))
                {
                    //Kiểm tra trùng Id
                    Guid id = new Guid(propertyValue.ToString());
                    var check = baseRepository.getById<entity>(id);
                    if(check != null)
                    {
                        serviceResult.isValid = false;
                        listError.Add(propertyName + "is not duplicate!");
                        serviceResult.code = statusCode.notValid;
                    }
                }
            }
            return serviceResult;
        }
    }
}
