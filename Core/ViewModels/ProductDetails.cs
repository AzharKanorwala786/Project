﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class ProductDetails
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}
