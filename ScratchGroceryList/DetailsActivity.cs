using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ScratchGroceryList
{
    [Activity(Label = "Grocery List")]
    class DetailsActivity : ItemsActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.DetailsPage);

            int position = Intent.GetIntExtra("ItemPosition", -1);

            var item = MainActivity.itemsList[position];

            FindViewById<TextView>(Resource.Id.nameTextView).Text = "Name: " + item.Name;
            FindViewById<TextView>(Resource.Id.countTextView).Text = "Count: " + item.Count;
        }

        protected override void OnStart()
        {
            base.OnStart();
        }
    }
}