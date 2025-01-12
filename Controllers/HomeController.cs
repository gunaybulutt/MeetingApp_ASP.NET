using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(info=>info.WillAttend==true).Count();
            //ViewBag.username = "Gunay";

            var meetingInfo = new MeetingInfo() 
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(model : meetingInfo);
        }
    }
}