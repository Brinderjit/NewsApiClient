using NewsApiClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsApiClient
{
    public partial class _Default : Page
    {
        string url = @"http://35.196.161.17/api/News/AllNews";
        public string stringSample;
        public NewsModel Models;
        private void prepareModelCollection()
        {

            var jsonString = new WebClient().DownloadString(url);
            stringSample = jsonString.ToString();
            Models = JsonConvert.DeserializeObject<NewsModel>(jsonString);


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            prepareModelCollection();
            ICollection<Articles> article = new List<Articles>();
            foreach(var a in Models.articles)
            {

                article.Add(new Articles { id = a.id, name = a.name, description = a.description, title = a.title, url = a.url, urlToImage = a.urlToImage, source = a.source });
            }
            newsDataList.DataSource=article;
            newsDataList.DataBind();
        }

    }
    
}