using Episode.Models;
using FinalProjectASP.NetcoreMVC.Models;
using FinalProjectASP.NetcoreMVC.Models.DataLayers;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProjectASP.NetcoreMVC.Controllers
{
    public class EpisodeController : Controller
    {

        private Repository<Models.Episode> episodes { get; set; }
        public EpisodeController(EpisodeContext ctx) => episodes = new Repository<Models.Episode>(ctx);
        public ViewResult Index()
        {
            var options = new QueryOptions<Models.Episode>
            {
                OrderBy = t => t.EpisodeId
            };
            return View(episodes.List(options));


        }
        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(Models.Episode episode)
        {
            if (ModelState.IsValid)
            {
                episodes.Insert(episode);
                episodes.Save();
                return RedirectToAction("Index");
            }
            else
            {
                episodes.Update(episode);
                return View(episode);
            }
        }
        

        [HttpGet]
        public ViewResult Delete(int id)
        {
            return View(episodes.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Delete(Models.Episode episode)
        {
            episodes.Delete(episode);
            episodes.Save();
            return RedirectToAction("Index");
        }
      


    }
}
