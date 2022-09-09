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

namespace App1.adapters
{
    public class NewsListAdapter : BaseAdapter<News>
    {
        private Activity _context;
        private List<News> _news;

        public NewsListAdapter(Activity context, List<News> news)
        {
            _context = context;
            _news = news;
        }

        public override News this [int position] => _news [position];   

        public override int Count => _news.Count;
        public override long GetItemId(int position) => _news [position].Id;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = this[position];

            if(convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.NewsListRow, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.newsTitle).Text = item.Title;
            var newsImage = convertView.FindViewById<ImageView>(Resource.Id.newsImage);

            var icon = _context.GetDrawable(Resource.Drawable.carnet);
            newsImage.SetImageDrawable(icon);
            return convertView;

        }
    }
}