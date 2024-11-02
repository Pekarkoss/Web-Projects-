using Microsoft.AspNetCore.Mvc;
using MeetingApp.Controllers;
using MeetingApp.Models;

namespace MeetingApp{
    public class HomeController : Controller{
        public IActionResult Index(){

            int saat = DateTime.Now.Hour;
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            var meetingInfo = new MeetingInfo(){
                   Id=1,
                   Location = "İstanbul",
                   Date = new DateTime(2024,2,2,2,2,2),
                   Numberofpeople = UserCount

            };
            return View(meetingInfo);
        }

    }
}