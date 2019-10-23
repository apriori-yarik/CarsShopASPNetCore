using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDBContent)
        {
            this.appDbContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
