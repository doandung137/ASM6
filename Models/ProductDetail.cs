using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonCategory.Models
{
    class ProductDetail
    { 
        public string message { get; set; }
        public DataProduct data{ get; set; }
    }
    class DataProduct
    {
     public Product product { get; set; }
     public List<Product> foods { get; set; }
    }
}
