using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required  (ErrorMessage ="Ad Alanı Zorunludur")]
        public string? Name { get; set; }
        [Required (ErrorMessage ="Telefon alanı zorunlu")]
        public int? Phone { get; set; }
        [Required (ErrorMessage ="Email Alanı Zorunlu")]
        [EmailAddress (ErrorMessage ="Hatalı Email")]
        public string? Email { get; set; }
        [Required (ErrorMessage ="Katılım Belirtin")]
        public bool? WillAttend { get; set; }


    }
}
