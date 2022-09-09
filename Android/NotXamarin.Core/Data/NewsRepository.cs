using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotXamarin.Core.Data
{
    public class NewsRepository
    {
        private List<News> _news;

        public NewsRepository()
        {
            _news = new List<News>
            {
                new News
                {
                    Id = 1,
                    Title = "Noticia desde el repostiorio",
                    Body = "Xamarin es una companai de sows",
                    ImageName = "noticia.jpg"
                },
                  new News
                {
                    Id = 2,
                    Title = "Noticia desde el repostiorio2",
                    Body = "Xamarin es una companai de sows 2",
                    ImageName = "noticia.jpg"
                },
                    new News
                {
                    Id = 3,
                    Title = "Noticia desde el repostiorio 3",
                    Body = "Xamarin es una companai de sows 3",
                    ImageName = "noticia.jpg"
                },
                      new News
                {
                    Id = 4,
                    Title = "Noticia desde el repostiorio 4",
                    Body = "Xamarin es una companai de sows 4",
                    ImageName = "noticia.jpg"
                }
            };
        }
    
    
        public List<News> GetNews()
        {
            return _news;
        }

        public News GetNewsId(int id)
        {
            return _news.FirstOrDefault(x=>x.Id == id);
        }
    }
}