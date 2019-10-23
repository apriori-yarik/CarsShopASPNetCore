using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "E-Cars", Description = "The most environmentally friendly type of transport." },
                    new Category { CategoryName = "SportCars", Description = "The fastest and the most modern cars" },
                    new Category { CategoryName = "CommutingCars", Description = "The most comfortable cars to spend your trip with."}
                };
            }
        }
    }
}
