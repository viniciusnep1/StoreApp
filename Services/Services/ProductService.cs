using AutoMapper;
using Data.Interface;
using Domain.Entities;
using Services.Dtos;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Product> repository;

        public ProductService(IRepository<Product> repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public ProductViewModel GetAll()
        {
            var products = repository.GetAll();
            var productViewModel = new ProductViewModel();
            var productsMap = mapper.Map<List<Product>>(products);
            foreach(var item in productsMap)
            {
                productViewModel.products.Add(item);
            }
            return productViewModel;
        }
    }
}
