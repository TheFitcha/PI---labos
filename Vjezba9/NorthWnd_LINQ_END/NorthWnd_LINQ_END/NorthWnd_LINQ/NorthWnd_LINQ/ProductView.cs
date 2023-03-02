using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWnd_LINQ
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? InStock { get; set; }
    }
}
