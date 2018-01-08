using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApiClient.Models
{
    public class NewsModel
    {
        public NewsModel()
        {
            articles = new List<Articles>();
        }
        public string status { get; set; }
        public ICollection<Articles> articles { get; set; }
    }
    public class Articles
    {
        public string title { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }


        public string urlToImage { get; set; }

        public source source { get; set; }

    }
    public class source
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}