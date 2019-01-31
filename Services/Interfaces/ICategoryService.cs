using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(Guid id);

        void Save(Category category);

        void Update(Category category);

    }
}
