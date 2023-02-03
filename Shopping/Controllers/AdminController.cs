using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Shopping.Models;
using Shopping.Repository;
namespace Shopping.Controllers
{
    public class AdminController : Controller
    {
        //private IHostingEnvironment _env;

        //public AdminController(IHostingEnvironment env) 
        //{
        //    _env = env;
        //}

        ShoponlContext db = new ShoponlContext();
        AdminRepository AR = new AdminRepository();
        public IActionResult Index()//C
        {
            return View();
        }

        public IActionResult Category()//C
        {
            List<Catelogy> cr = AR.GetAllCat();
            ViewBag.catelogylist = cr;
            return View();
        }

        public IActionResult UserInfo() //U
        {
            List<User> us = AR.GetAllUser();
            ViewBag.userlist = us;
            return View();
        }
        public IActionResult ProductList()//P
        {
            List<Product> pr = AR.GetAllPro();
            ViewBag.productlist = pr;
            return View();
        }

        public IActionResult CreateCategory()//CC
        {
            Catelogy C = new Catelogy();
            return View(C);
        }

        [HttpPost]
        public IActionResult CreateCategory(Catelogy C)
        {
            if (ModelState.IsValid)
            {

                // insert into table category
                db.Catelogies.Add(C);

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(C);
        }
        public IActionResult CreateProduct()//CP
        {
            ProductCreate proc = new ProductCreate();

            return View(proc);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductCreate proc, IFormFile file)
        {
            db.Products.Add(proc.pr);
            db.SaveChanges();
            //lấy mã của product id ra từ bảng product

            var proid = db.Products.OrderByDescending(x => x.ProductId).FirstOrDefault().ProductId;

            if (file != null)
            {
                if (file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var newfileName = string.Concat(Convert.ToString(Guid.NewGuid()),fileName);
                    var img = new ProductImage()
                    {
                        ProductFk = proid,  //productid từ dòng 80
                        Image = newfileName,
                        MainImage = 1

                    };
                    using (var target = new MemoryStream())
                    {
                        file.CopyTo(target);
                    }
                    db.ProductImages.Add(img);
                    db.SaveChanges();
                }
            }



            return View(proc);
        }

        


        public IActionResult EditProduct(int id)//EDP
        {
            Product P = db.Products.Find(id);
            return View(P);
        }

        [HttpPost]
        public IActionResult EditProduct(Product P)
        {
            if (ModelState.IsValid)
            {

                // update into table category
                Product productdb = db.Products.Find(P.ProductId);
                //update category name
                productdb.ProductName = P.ProductName;
                productdb.ProductPrice = P.ProductPrice;
                productdb.ProductDescription = P.ProductDescription;
                productdb.ProductStatus = P.ProductStatus;
                productdb.CatelogyId = P.CatelogyId;
                productdb.ProductDiscount = P.ProductDiscount;
                productdb.ProductUrlvideo = P.ProductUrlvideo;
                productdb.ProductUnit = P.ProductUnit;
                productdb.RatingAvg = P.RatingAvg;

                db.SaveChanges();

                return RedirectToAction("ProductList");
            }
            return View(P);
        }

        public IActionResult EditCatelogy(int id)//EDC
        {
            Catelogy catelogy = db.Catelogies.Where(c => c.CategoryId == id).SingleOrDefault();
            return View(catelogy);
        }
        [HttpPost]
        public IActionResult EditCatelogy(Catelogy catelogy)
        {
            if (ModelState.IsValid)
            {
                // update into table category
                Catelogy catelogydb = db.Catelogies.Where(c => c.CategoryId == catelogy.CategoryId).SingleOrDefault();
                //update category name
                catelogydb.CategoryName = catelogy.CategoryName;
                catelogydb.CategoryIdparent = catelogy.CategoryIdparent;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(catelogy);

        }

        public IActionResult DeleteCatelogy(int id) //DC
        {
            //remove item in db
            Catelogy catelogydb = db.Catelogies.Where(c => c.CategoryId == id).SingleOrDefault();
            db.Catelogies.Remove(catelogydb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id) //DP
        {
            //remove item in db
            Product productdb = db.Products.Where(p => p.ProductId == id).SingleOrDefault();
            db.Products.Remove(productdb);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult OrderList() //đọc danh sách hóa đơn
        {

            List<Order> or = AR.GetAllOrder();
            ViewBag.orderList = or;
            return View();
        }
        //lọc các hóa đơn có trong ngày, các hóa đơn từ ngày nào đến ngày nào
        
    }
}
