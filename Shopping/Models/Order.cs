using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Total { get; set; }
        public string Status { get; set; }
        public string Payment { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? Phivc { get; set; }
        public string UserName { get; set; }
        public string Adress { get; set; }
        public string PhoneNum { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
