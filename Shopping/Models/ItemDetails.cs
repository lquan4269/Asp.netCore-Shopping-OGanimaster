using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class ItemDetails
    {
        public String img { get; set; } // hình ảnh
        public Product productDetai { get; set; }
        public int Quantity { get; set; }
    }
}
