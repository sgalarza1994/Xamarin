using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.adapters;
using NotXamarin.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    [Activity(Label = "NewsListActivity",MainLauncher =true)]
    public class NewsListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.NewsList);
            // Create your application here
            //adaptador una clase que se encarga de gestionar los elementos de un list view
            //debe crear una vista para cada elemento de un listView

            var newsListView = FindViewById<ListView>(Resource.Id.newsListView);

            var newsService = new NewsService();
            var news = newsService.GetNews();

            newsListView.Adapter = new NewsListAdapter(this, news);

            newsListView.ItemClick += NewsListView_ItemClick;
        }

        private void NewsListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this,typeof(MainActivity));
            intent.PutExtra(MainActivity.KEY_ID,(int)e.Id);
            StartActivity(intent);
        }
    }
}