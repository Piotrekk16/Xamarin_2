using Android.App;
using Android.Widget;
using Android.OS;

using Android.Content;
using Android.Views;


namespace PierwszaAplikacja
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }
        [Java.Interop.Export("Call")]
        public void Call(View view)
        {
            EditText phoneNumber = FindViewById<EditText>(Resource.Id.PhoneNumber);

            var callIntent = new Intent(Intent.ActionCall);
            callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber.Text));
            StartActivity(callIntent);
        }
    }
}

