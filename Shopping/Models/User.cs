using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PhoneNum { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
