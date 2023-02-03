using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductComments = new HashSet<ProductComment>();
            ProductImages = new HashSet<ProductImage>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductStatus { get; set; }
        public int? CatelogyId { get; set; }
        public decimal? ProductDiscount { get; set; }
        public string ProductUrlvideo { get; set; }
        public string ProductUnit { get; set; }
        public double? RatingAvg { get; set; }

        public virtual Catelogy Catelogy { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
