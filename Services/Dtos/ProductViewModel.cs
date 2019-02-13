using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dtos
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            this.products = new List<Product>();
        }

        public List<Product> products { get; set; }
    }
}
