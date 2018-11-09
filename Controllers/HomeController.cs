using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechNews.Data;
using TechNews.Models;

namespace TechNews.Controllers
{
    public class HomeController : Controller
    {
        private NewsRepository newsRepository;
        public HomeController()
        {
            newsRepository = new NewsRepository();
        }

        public IActionResult Index()
        {
            var news = newsRepository.GetFeaturedNews();
            return View(news);
        }

        public IActionResult Search(string searchTerm)
        {
            var news = newsRepository.SearchNews(searchTerm);
            ViewBag.SearchTerm = searchTerm;
            return View(news);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
