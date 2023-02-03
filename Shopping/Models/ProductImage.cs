using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class ProductImage
    {
        public int ProductFk { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }
        public int? MainImage { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
    }
}
