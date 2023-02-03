using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Shopping.Models
{
    public class RegisterModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "Chiều dài tối thiểu là 4 ký tự")]
        [MaxLength(60, ErrorMessage = "Chiều dài tối đa là 60 ký tự")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Không đúng định dạng email")]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Adress { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Chiều dài tối thiểu là 4 ký tự")]
        [MaxLength(60, ErrorMessage = "Chiều dài tối đa là 60 ký tự")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp")]
        public string CofirmPassword { get; set; }

    }

    public class LoginModel
    {
        [Required(ErrorMessage = "Không được để trống !")]
        [EmailAddress(ErrorMessage = "Không đúng định dạng email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được để trống !")]
        [MinLength(4, ErrorMessage = "Chiều dài tối thiểu là 4 ký tự")]
        [MaxLength(60, ErrorMessage = "Chiều dài tối đa là 60 ký tự")]
        public string Password { get; set; }
    }
}
