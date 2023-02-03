using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class ProductComment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserComment { get; set; }
        public int? Rating { get; set; }
        public DateTime? RatingDate { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
