using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;
using Microsoft.EntityFrameworkCore;
namespace Shopping.Repository
{
    public class ProductRepository
    {
        ShoponlContext db = new ShoponlContext();
        public ProductRepository()
        {

        }
        public List<Product> GetAll()
        {
            return db.Products.Include(x => x.ProductImages).ToList();
            
        }

        public Product GetById(int id)
        {
            return db.Products.Where(x => x.ProductId == id).Include(x => x.ProductImages).FirstOrDefault();

        }


        public List<Product> GetAll_searchproduct(int CID)
        {

            return db.Products.Where(C => C.CatelogyId == CID).ToList();

        }

        

        //public List<Catelogy> Catelogies()
        //{
        //    return db.Catelogies.Include(x => x.CategoryId).ToList();
        //}

        //public List<Product> Products(int id){
        //    return db.Products.Where(x => x.CatelogyId == id).ToList();
        //}




    }
}
