using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dtos
{
    public class CategoryViewModel
    {
        public List<Category> categories;
        public CategoryViewModel()
        {
            categories = new List<Category>();
        }
    }
}
