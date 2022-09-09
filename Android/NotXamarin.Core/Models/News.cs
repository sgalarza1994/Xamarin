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
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string Body { get; set; }
        public string ImageName { get; set; }
    }
}