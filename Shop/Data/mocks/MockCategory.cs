﻿using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories { 
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Electrocar", desc = "Modern type of transport"},
                    new Category{categoryName = "Classic car", desc = "The cars with the internal combustion engine"}
                };
            }
        }
    }
}
