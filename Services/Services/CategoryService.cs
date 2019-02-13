using AutoMapper;
using Data.Interface;
using Domain.Entities;
using Services.Dtos;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> repository;
        private readonly IMapper mapper;

        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public CategoryViewModel GetAll()
        {
            var categories = repository.GetAll();
            var categoryMap = mapper.Map<List<Category>>(categories);
            var categoryViewModel = new CategoryViewModel();
            foreach (var item in categoryMap)
                categoryViewModel.categories.Add(item);

            return categoryViewModel;
        }

        public Category GetById(Int64 id)
        {
            var category = repository.Get(id);
            return category;
        }

        public void Save(Category category)
        {
            repository.Insert(category);
        }

        public void Update(Category category)
        {

            repository.Update(category);
        }
    }
}
