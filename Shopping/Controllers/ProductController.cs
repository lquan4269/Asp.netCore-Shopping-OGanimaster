using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.Models;
using Shopping.Repository;

namespace Shopping.Controllers
{
    public class ProductController : Controller
    {

        ProductRepository CRepository = new ProductRepository();
        public IActionResult Details(int id)
        {

            Product sp = CRepository.GetAll().FirstOrDefault(x => x.ProductId == id);
            ItemDetails model = new ItemDetails()
            {
                img  = sp.ProductImages.ToList()[0].Image,
                productDetai = sp,
                Quantity = 1
            };
            return View(model);
        }

        //public IActionResult LoadCategory(int id)
        //{
        //    Catelogy cate = CRepository.Catelogies().FirstOrDefault(x => x.CategoryId == id);
        //    ViewBag.catelo = cate;
        //    return View(cate);
        //}

        
    }
}
