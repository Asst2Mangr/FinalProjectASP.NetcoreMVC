using FinalProjectASP.NetcoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProjectASP.NetcoreMVC.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


    }
}