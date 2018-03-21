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
    [Activity(Label = "Add Item")]
    public class AddActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AddItem);

            var saveButton = FindViewById<Button>(Resource.Id.saveButton);
            var cancelButton = FindViewById<Button>(Resource.Id.cancelButton);

            saveButton.Click += OnSaveClick;
            cancelButton.Click += OnCancelClick;
        }

        void OnSaveClick(object sender, EventArgs e)
        {
            var nameText = FindViewById<EditText>(Resource.Id.nameTextField).Text;
            var countText = FindViewById<EditText>(Resource.Id.countTextField).Text;

            int countInt = 0;
            Int32.TryParse(countText, out countInt);

            var intent = new Intent();

            intent.PutExtra("ItemName", nameText);
            intent.PutExtra("ItemCount", countText);

            SetResult(Result.Ok, intent);

            Finish();
        }

        void OnCancelClick(object sender, EventArgs e)
        {
            Finish();
        }
    }
}
