using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.wwwroot.Repository
{
    public class CatelogyRepository
    {
        ShoponlContext db = new ShoponlContext();

        public List<Catelogy> GetAll() {

            return db.Catelogies.ToList();
        }
        public List<Catelogy> GetAll_Supcatelogy(int CID) {

            return db.Catelogies.Where(C => C.CategoryIdparent == CID).ToList();

        }

        public void Catelogy() 
        {
            
        }

        

    }
}
