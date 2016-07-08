using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LunchBoxUI
{
    [Activity(Label = "LunchBoxUI", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button mbtnSignUp;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mbtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            mbtnSignUp.Click += (object sender, EventArgs e) =>
            {
                FragmentTransaction frgmentTranc = FragmentManager.BeginTransaction();

                dialogue_SignUp signUpDialog = new dialogue_SignUp();
                signUpDialog.Show(frgmentTranc, "dialog frament");

            };
        }
    }
}

