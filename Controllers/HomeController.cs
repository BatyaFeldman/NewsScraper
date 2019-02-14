using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TlsScraper.Api;

namespace TlsScraper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Scraper scraper = new Scraper();
            IEnumerable<Article> posts = scraper.GetArticles();
            return View(posts);
        }

       
    }
}