using Android.App;
using Android.Content; // Import this for Intent
using Android.Content.PM;
using Android.OS;
using System.IO; // Import this for StreamWriter
using System;

namespace TaskMaster
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
       
    }
}
