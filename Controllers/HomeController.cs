using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnet_formapp.Models;

namespace aspnet_formapp.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View(Repository.Products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
