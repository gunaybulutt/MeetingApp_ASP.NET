using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Hatalı Ad-Soyad")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Hatalı Telefon")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Hatalı Email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Seçim Yapılmadı")]
        public bool? WillAttend { get; set; }
    }
}