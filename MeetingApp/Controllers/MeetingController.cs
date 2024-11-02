using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
using System.Runtime.CompilerServices;

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

            if (ModelState.IsValid)
            {

                Repository.CreateUser(model);
                return View("Thanks", model);
            }
            else
            {
                  return View(model);
            }
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View(Repository.Users);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}