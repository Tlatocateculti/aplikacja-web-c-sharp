using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.TagHelper
{
    public class Product
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product()
        {


            Number = 1;
            Name = "Test product";
            Description = "This is a test product";
           
        }
    }
}
