using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {

        public int Id { set; get; }

        public string Name { set; get; }

        public string ShortDescription { set; get; }

        public string LongDescription { set; get; }

        public string Image { set; get; }

        public int Price { set; get; }

        public bool IsFavourite { set; get; }

        public bool Available { set; get; }

        public int CategoryID { set; get; }

        public virtual Category Category { set; get; }

    }
}
