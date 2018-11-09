using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TechNews.Models;

namespace TechNews.Data
{
    public class NewsRepository
    {
        public IEnumerable<NewsViewModel> GetNews()
        {
            using (StreamReader r = new StreamReader("Data/top-headlines.json"))
            {
                string json = r.ReadToEnd();
                List<NewsViewModel> news = JsonConvert.DeserializeObject<List<NewsViewModel>>(json);
                return news;
            }
        }

        public IEnumerable<NewsViewModel> GetFeaturedNews()
        {
            var news = GetNews();
            // Some "Random" News as featured
            return news.Skip(2).Take(3);
        }

        public IEnumerable<NewsViewModel> SearchNews(string searchTerm, int publishedYear = 0)
        {
            var newsQuery = GetNews().Where(n => n.Description.Contains(searchTerm));

            if (publishedYear != 0)
                newsQuery = newsQuery.Where(n => n.PublishedAt.Year == publishedYear);
            return newsQuery.ToList();
        }
    }
}
