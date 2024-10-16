using System.Reflection.Metadata.Ecma335;
using AspBasics.Controllers;
using AspBasics.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace basic.Controllers;


public class CourseController : Controller
{

    
    public IActionResult Details(int? id)
    {
        if(id == null){
            return Redirect("/Course/List");
        }
        var kurs = Repository.GetbyId(id.Value);

        return View(kurs);
    }

    public IActionResult List()
    {
        return View("List", Repository.Courses);
    }


}