using Shopping.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Repository
{
    public class UserRepository
    {
        ShoponlContext db = new ShoponlContext();



        public bool CheckUserName(string Name)
        {
            List<User> userList = (from user in db.Users where user.UserName == Name select user).ToList();
            if (userList.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckEmail(string Email)
        {
            List<User> emailList = (from user in db.Users where user.Email == Email select user).ToList();
            if (emailList.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckPassowrd(string Password)
        {
            List<User> passwordList = (from user in db.Users where user.Password == Password select user).ToList();
            if (passwordList.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckLogin(string Email, string Password)
        {
            User user = db.Users.Where(m => m.Email == Email).FirstOrDefault();
            if (user != null)
            {
                if (user.Password == Encrypt.MD5Hash(Password))
                    return true;
            }
            return false;
        }
    }
}
