using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspBasics.Models;

namespace AspBasics.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(Repository.Courses);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contact(){
        return View();
    }
}
