﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShopDemo.Core.Models;

namespace MyShopDemo.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
