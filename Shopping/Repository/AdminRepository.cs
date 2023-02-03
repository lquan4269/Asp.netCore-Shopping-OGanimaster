using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Repository
{
    public class AdminRepository
    {
        ShoponlContext db = new ShoponlContext();

        public List<Catelogy> GetAllCat()
        {

            return db.Catelogies.ToList();
        }

        public List<User> GetAllUser()
        {

            return db.Users.ToList();
        }

        public List<Product> GetAllPro()
        {

            return db.Products.ToList();
        }

        public List<Product> GetAllimg()
        {
            return db.Products.Include(x => x.ProductImages).ToList();

        }

        public List<Order> GetAllOrder()
        {
            return db.Orders.ToList();
        }


    }
}
