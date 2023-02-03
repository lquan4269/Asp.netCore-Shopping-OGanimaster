using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class Catelogy
    {
        public Catelogy()
        {
            InverseCategoryIdparentNavigation = new HashSet<Catelogy>();
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryIdparent { get; set; }

        public virtual Catelogy CategoryIdparentNavigation { get; set; }
        public virtual ICollection<Catelogy> InverseCategoryIdparentNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        internal static List<Catelogy> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
