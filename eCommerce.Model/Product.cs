using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class Product
    {
        public int PropertyID { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
