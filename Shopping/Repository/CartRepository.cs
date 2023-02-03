using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;
namespace Shopping.Repository
{
    public class CartRepository 
    {
        ShoponlContext db = new ShoponlContext();
        private List<ItemDetails> items = new List<ItemDetails>();
        

        public int AddToCart(ItemDetails item)
        {
            ProductRepository pr = new ProductRepository();
            bool found = false;
            item.img = pr.GetById(item.productDetai.ProductId).ProductImages.ToList()[0].Image;//lấy danh sách img từ product id
            foreach (ItemDetails i in items)
            {

                if (i.productDetai.ProductId == item.productDetai.ProductId)
                {
                   
                    i.Quantity += item.Quantity;
                    found = true;
                }
            }
            if (!found)
            {
                items.Add(item);
            }
      
            return items.Count;
        }

        public decimal? total()
        {
            decimal? total = 0;
            foreach (ItemDetails i in items)
            {
                total += i.productDetai.ProductPrice * i.Quantity;
            }
            return total;
        }

        public Product getDetailsProduct(int ID)
        {
            Product p = db.Products.Find(ID);
            return p;
        }

        public void SetItem(List<ItemDetails> it) {

            items = it;
        }

        public List<ItemDetails> getAllitems()
        {
            return items;
        }
    }
}
