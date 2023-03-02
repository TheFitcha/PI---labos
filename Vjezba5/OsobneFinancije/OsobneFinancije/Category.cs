using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobneFinancije
{
    internal class Category
    {
        public Category SubCategoryOf { get; set; }
        public string Name { get; set; }    
        public string Color { get; set; }
        public Category(string name, string color, Category category = null)
        {
            Name = name;
            Color = color;
            SubCategoryOf = category;
        }
    }
}
