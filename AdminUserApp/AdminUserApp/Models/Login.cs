using System.ComponentModel.DataAnnotations;

namespace AdminUserApp.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Kullanıcı isminizi girmediniz")]
        [Display(Name = "Kullanıcı Adı")]
        public string username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalı.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string password { get; set; }
    }
}