using Domain.Entities;
using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel GetAll();

        Category GetById(Int64 id);

        void Save(Category category);

        void Update(Category category);

    }
}
