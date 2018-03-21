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
    [Activity]
    public class ItemsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ItemsPage);

            var listView = FindViewById<ListView>(Resource.Id.listView);
            listView.Adapter = new ArrayAdapter<Item>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, MainActivity.itemsList);

            listView.ItemClick += OnItemClick;
        }

        void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(DetailsActivity));

            intent.PutExtra("ItemPosition", e.Position);

            StartActivity(intent);
        }
    }
}