using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NotXamarin.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotXamarin.Core.Services
{
    public class NewsService
    {
        private NewsRepository newsRepository;
        public NewsService()
        {
            newsRepository = new NewsRepository();
        }

        public List<News> GetNews() => newsRepository.GetNews();

        public News GetNewsBiId(int id) => newsRepository.GetNewsId(id);
    }
}