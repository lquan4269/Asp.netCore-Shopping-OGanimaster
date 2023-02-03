using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Shopping.Models;



namespace Shopping.Repository
{
    public class OderRepository 
    {
        ShoponlContext db = new ShoponlContext();
        CartRepository carts = new CartRepository();
        private List<ItemDetails> items = new List<ItemDetails>();
        public decimal? total()
        {

            decimal? total = 0;
            foreach (ItemDetails i in items)
            {
                total += i.productDetai.ProductPrice * i.Quantity;
            }
            return total;
        }
        public void CreateOrder(List<ItemDetails> items, User u)
        {
                var user = db.Users.Where(x => x.Email == u.Email).SingleOrDefault();//tài khoản tham chiếu bề bảng user
                Order order = new Order()
                {
                    UserId = user.UserId,//tham chiếu
                    Date = DateTime.Now,
                    Total = total(),
                    Status = "0",
                    Payment = "MOMO",
                    PurchaseDate = DateTime.Now,
                    Phivc = 0,
                    UserName = u.UserName,//tài khoản của ng nhận
                    Adress = u.Adress,
                    PhoneNum = u.PhoneNum
                };
                db.Orders.Add(order);
                db.SaveChanges();
                var orderid = db.Orders.OrderByDescending(x => x.OrderId).First().OrderId;
                //orderid
                //getorder ID mới được tạo
                foreach (var it in items)
                {
                    var orderDerdetails = new OrderDetail
                    {
                        OrderId = orderid, //lấy orderid ở dòng 35
                        ProductId = it.productDetai.ProductId,
                        Quantity = it.Quantity,
                        Price = total(),
                    };
                    db.OrderDetails.Add(orderDerdetails);

                }
            
                db.SaveChanges();
            }

    }
}
