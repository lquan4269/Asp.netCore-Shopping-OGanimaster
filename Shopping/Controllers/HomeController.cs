using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.Models;
using Shopping.Repository;
using Shopping.wwwroot.Repository;



namespace Shopping.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductRepository CRepository = new ProductRepository();
        CatelogyRepository CTRepository = new CatelogyRepository();
        ShoponlContext db = new ShoponlContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> pr = CRepository.GetAll();
            ViewBag.productlist = pr;

            return View();
        }
        public IActionResult Shop()
        {
            List<Product> products = CRepository.GetAll().ToList();
            ViewBag.productlist = products;
            return View();
        }

        public IActionResult _LoadCatelogy() {

            List<Catelogy> cat = CTRepository.GetAll();

            return PartialView(cat);
        }

        public IActionResult ListCatelogy(int cateid)
        {
            //List<Product> pr = CRepository.GetAll();
            //List<Catelogy> cat = CTRepository.GetAll();

            //var catepro = from category in cat
            //              join product in pr on category equals product.CatelogyId into gj
            //              from subpro in gj.DefaultIfEmpty()
            //              select


            return View();
        }

        //liet ke cac hoa don trong ngay
        //chi tiet hoa don, trang thai hoa don
        //trang thai don hang
        //tong danh thu don hang ban chay

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
