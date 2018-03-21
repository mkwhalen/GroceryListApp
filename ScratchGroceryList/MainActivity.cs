using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using System.Collections.Generic;
using Android.Runtime;

namespace ScratchGroceryList
{
    [Activity(Label = "Grocery List", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        public static List<Item> itemsList = new List<Item>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            //Calls click event handlers for Add Item, Item List, and About views

            FindViewById<Button>(Resource.Id.itemListButton).Click += OnItemsClick;
            FindViewById<Button>(Resource.Id.addItemButton).Click += OnAddButtonClick;
            FindViewById<Button>(Resource.Id.aboutButton).Click += OnAboutButtonClick;
        }


        private void OnItemsClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ItemsActivity));

            StartActivity(intent);
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AddActivity));

            StartActivityForResult(intent, 100);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == 100 && resultCode == Result.Ok)
            {
                var name = data.GetStringExtra("ItemName");
                var count = data.GetIntExtra("ItemCount", 0);

                MainActivity.itemsList.Add(new Item(name, count));
            }
        }
        private void OnAboutButtonClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AboutActivity));

            StartActivity(intent);
        }

    }
}

