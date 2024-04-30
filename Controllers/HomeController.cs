using Episode.Models;
using FinalProjectASP.NetcoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProjectASP.NetcoreMVC.Models.DataLayers;
using System.Diagnostics;
using System.Security.Claims;

namespace FinalProjectASP.NetcoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private EpisodeUnitOfWork data { get; set; }

        public HomeController(EpisodeContext ctx)
        {
            data = new EpisodeUnitOfWork(ctx);
            
        }

        public ViewResult Index(int id)
        {
 

            var dayOptions = new QueryOptions<Models.Episode>
            {
                OrderBy = d => d.EpisodeId == id,
            };



            // execute queries
            ViewBag.Season = data.Episodes.List(dayOptions);
            return View(data.Episodes.List(dayOptions));
        }
        
        private void LoadViewBag(string operation)
        {
            ViewBag.Season = data.Episodes.List(new QueryOptions<Models.Episode>
            {
                OrderBy = d => d.Season
            });
          
            ViewBag.Operation = operation;
        }
        

    }
}