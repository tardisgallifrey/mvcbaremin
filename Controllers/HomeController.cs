//using System.Diagnostics; //remove comment lines to use
using Microsoft.AspNetCore.Mvc;
//using mvcbaremin.Models; //remove comment lines to use

//This is the smallest MVC app that I could write, safely

namespace mvcbaremin.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

   
}
