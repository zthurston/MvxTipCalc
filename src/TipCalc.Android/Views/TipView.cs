using System;
using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Shared.ViewModels;

namespace TipCalc.Android.Views
{
    [Activity(Label = "Tip Calculator", MainLauncher = true)]
    public class TipView : MvxActivity<TipViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TipView);
        }
    }
}
