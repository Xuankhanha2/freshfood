using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class ProductService:BaseService, IProductService
    {
        IProductRepository productRepository;
        public ProductService(IProductRepository _productRepository) : base(_productRepository)
        {
            productRepository = _productRepository;
        }
    }
}
