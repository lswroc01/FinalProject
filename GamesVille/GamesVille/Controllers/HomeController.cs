using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamesVille.Models;

namespace GamesVille.Controllers
{
    public class HomeController : Controller
    {
        private GameDBContext db = new GameDBContext();

        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

         //GET: /Games/Details/5
        public ActionResult More(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }


        //GET: /Games/Details/5
        public ActionResult FilterCategory(string category)
        {
            var CatList = new List<string>();

            var CatQuery = from d in db.Games
                           select d.Category;

            CatList.AddRange(CatQuery.Distinct());
            ViewBag.gameCategory = new SelectList(CatList);

            var games = from g in db.Games
                        select g;

            if(!string.IsNullOrEmpty(category))
            {
                games = games.Where(x => x.Category == category);
            }

            return View(games);
        }

        public ActionResult FilterPlatform(string platform)
        {
            var CatList = new List<string>();

            var CatQuery = from d in db.Games
                           select d.Platform;

            CatList.AddRange(CatQuery.Distinct());
            ViewBag.gamePlatform = new SelectList(CatList);

            var games = from g in db.Games
                        select g;

            if (!string.IsNullOrEmpty(platform))
            {
                games = games.Where(x => x.Platform == platform);
            }

            return View(games);
        }

        public ActionResult FilterESBR(string esrb)
        {
            var CatList = new List<string>();

            var CatQuery = from d in db.Games
                           select d.ESBR_Rating;

            CatList.AddRange(CatQuery.Distinct());
            ViewBag.gameESBR_Rating = new SelectList(CatList);

            var games = from g in db.Games
                        select g;

            if (!string.IsNullOrEmpty(esrb))
            {
                games = games.Where(x => x.ESBR_Rating == esrb);
            }

            return View(games);
        }


        //public ActionResult More(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Game game = db.Games.Find(id);
        //    if (game == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(game);
        //}
    }
}