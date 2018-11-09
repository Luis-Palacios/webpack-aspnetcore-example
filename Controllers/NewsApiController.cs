using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechNews.Data;

namespace TechNews.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsApiController : ControllerBase
    {
        private NewsRepository newsRepository;

        public NewsApiController()
        {
            newsRepository = new NewsRepository();
        }

        // GET: api/news
        [HttpGet]
        public IActionResult Get(string searchTerm = "", int publishedYear = 0)
        {
            var news = newsRepository.SearchNews(searchTerm, publishedYear);
            return Ok(news);
        }

    }
}
