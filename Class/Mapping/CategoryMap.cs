using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class CategoryMap
    {
        public CategoryMap(EntityTypeBuilder<Category> category)
        {
            category.HasKey(t => t.Id);
            category.Property(t => t.Name).IsRequired();
        }
    }
}
