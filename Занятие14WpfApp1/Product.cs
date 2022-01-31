using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие14WpfApp1
{
    public enum ProductTypes
    {
        Meal,
        HomeAppliances
    }

    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Priority { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
