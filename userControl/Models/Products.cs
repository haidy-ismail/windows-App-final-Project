using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userControl.Models
{
    public class Products
    {
        public int? productId { get; set; }
        public string productName { get; set; }
        public double sellingPrice { get; set; }
        public int quantity { get; set; }
        public double buyingPrice { get; set; }
        public string disc { get; set; }
        public string category { get; set; }
        public string imageName { get; set; }
        public byte[] bytes { get; set; }
    }
}
