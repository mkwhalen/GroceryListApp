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
    /// <summary>
    /// Displays about page 
    /// </summary>
    
    [Activity(Label = "About")]
   public class AboutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.About);
            FindViewById<Button>(Resource.Id.learnMoreButton).Click += OnLearnMoreClick;    
                
                }

        void OnLearnMoreClick(Object sender, EventArgs e)
        {
            var intent = new Intent();

            intent.SetAction(Intent.ActionView);
            intent.SetData(Android.Net.Uri.Parse("http://www.mackenziewhalen.com"));

            StartActivity(intent);
        }



    }
}