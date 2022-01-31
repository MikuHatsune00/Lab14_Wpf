using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Wpf
{   public enum ProductTypes 
    { 
        Electronics,
        Beverages
    }
    public class Product
    {
        public string ProductName { get; set; } 
        public uint ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }
        

    }
}
