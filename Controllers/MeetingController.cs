using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            // Using string interpolation to format the message
            //Console.WriteLine($"Name: {model.Name}, Email: {model.Email}, Phone: {model.Phone}, WillAttend: {model.WillAttend}");
            if(ModelState.IsValid){
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
                return View("Thanks", model);
            }else{
                return View(model);
            }
            
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}