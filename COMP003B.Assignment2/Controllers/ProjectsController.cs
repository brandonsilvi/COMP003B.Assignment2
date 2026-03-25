using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers;

public class ProjectsController : Controller
{
    public IActionResult  Current()
    {
        return View();
    }

    public IActionResult Completed()
    {
        return View();
    }

    public IActionResult Ideas()
    {
        return View();
    }
}