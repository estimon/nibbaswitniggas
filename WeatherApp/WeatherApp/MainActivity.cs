﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var button = FindViewById<Button>(Resource.Id.button1);
            

            button.Click += Button_Click;

            
        }
        private async void Button_Click(object sender, System.EventArgs e)
        {
            var textview = FindViewById<TextView>(Resource.Id.textView1);
            var weather = await Core.Core.GetWeather("asd");
            textview.Text = weather.Temperature;
            
        }
    }
}