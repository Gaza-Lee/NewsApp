using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using NewsApp.NewFolder;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            // Implement the logic to fetch news articles from an API
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?category="+ categoryName.ToLower() + "&apikey=dd7e6325109285f50836044dc9144c93&lang=en&");

            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
