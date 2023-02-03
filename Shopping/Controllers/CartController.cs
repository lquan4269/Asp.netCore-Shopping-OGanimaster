using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shopping.Models;
using Shopping.Repository;

namespace Shopping.Controllers
{
    public class CartController : Controller
    {
        ShoponlContext db = new ShoponlContext();
        ProductRepository pro = new ProductRepository(); 
        CartRepository carts = new CartRepository();
        OderRepository OD = new OderRepository();

        [HttpPost]
        public IActionResult AddtoCart(ItemDetails model)
        {

            var sessionID = HttpContext.Session.Id;
            ViewBag.SessionID = sessionID;
            var c = HttpContext.Session.GetString("cart"); //convert đối tượng về chuỗi
                                                           
             // đối tượng rỗng

            if (c == null) 
            {

                carts.AddToCart(model);
                var s = JsonConvert.SerializeObject(carts.getAllitems());
                HttpContext.Session.SetString("cart",s); //chuyển đối tượng từ CartRepository thành chuỗi

            }
            else {
                
               List<ItemDetails> It = JsonConvert.DeserializeObject<List<ItemDetails>>(c); // đổi từ chuỗi ngược về
                carts.SetItem(It); //chép ngược lại
                carts.AddToCart(model);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(carts.getAllitems()));
            }
            List<ItemDetails> items = carts.getAllitems();
            ViewBag.Total = carts.total();

            return View("cart",items);
        }

        public IActionResult Checkout() 
        {

            var sessionID = HttpContext.Session.Id;
            ViewBag.SessionID = sessionID;
            var c = HttpContext.Session.GetString("cart");
            List<ItemDetails> items = carts.getAllitems();
            decimal? total = 0;
            if (items.Count != null)
            {
                items = JsonConvert.DeserializeObject<List<ItemDetails>>(c);

                foreach (ItemDetails i in items)
                {
                    total += i.productDetai.ProductPrice * i.Quantity;
                }
                ViewBag.total = total;
            }
            User user = new User();
            var Emailuser = HttpContext.Session.GetString("Email"); //lấy email trong session

            //List<User> users = JsonConvert.DeserializeObject<List<User>>(us);
            //var user = db.Users.Where(x => x.Email == user.Email).SingleOrDefault();
            
            if (Emailuser != null) //neu co user thi no se in ra thong tin user
            {
                var kh = db.Users.AsNoTracking().SingleOrDefault(x => x.Email == Emailuser);  //đọc cái email trong session
                user.UserId = kh.UserId;
                user.UserName = kh.UserName;
                user.Email = kh.Email;
                user.Adress = kh.Adress;
                user.PhoneNum = kh.PhoneNum;
            }
            //else 
            //{
            //    user = new User();
            //}
            CheckOutModel model = new CheckOutModel() {
                it = items,
                u =  user
            };
            //sau khi user đăng nhập lưu email ng dùng vào trong session
            return View(model);
        }
 
        [HttpPost]
        public IActionResult Checkout(CheckOutModel model)
        {
            var sessionID = HttpContext.Session.Id;
            var c = HttpContext.Session.GetString("cart");
            List<ItemDetails> It = JsonConvert.DeserializeObject<List<ItemDetails>>(c);
            model.it = It;
            if (ModelState.IsValid)
            {
                if (sessionID != null) // 2 truong hop
                {
                    
                    var kh = db.Users.SingleOrDefault(x => x.Email == model.u.Email);
                    if (kh == null)
                    {

                        return RedirectToAction("Login", "User");

                    }
                    else
                    {
                          User u = model.u;
                        //lay user ra in vao order
                        //kh.UserId = u.UserId;
                        kh.UserName = u.UserName ;
                        kh.Email = u.Email  ;
                        kh.Adress = u.Adress  ;
                        kh.PhoneNum = u.PhoneNum  ;
                        db.Update(kh);
                    }
                 }
                   OD.CreateOrder(model.it,model.u);
                   db.SaveChanges();
            }

            HttpContext.Session.Remove("cart");
            return RedirectToAction( "checkoutcomplete");
        }

        public IActionResult checkoutcomplete()
        {
            ViewBag.checkoutcomplete = HttpContext.User.Identity.Name + ", thanks for your order!";
            return View();
        }


    }
}
