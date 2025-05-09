using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adını giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadını giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen fotoğraf yolu giriniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail giriniz.")]
        public string Mail { get; set; }
    }
}
