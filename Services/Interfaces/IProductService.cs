﻿using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetAll();
    }
}
