using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> product)
        {
            product.HasKey(t => t.Id);
            product.Property(t => t.Name).IsRequired();
        }
    }
}
