using Foundation;
using MvvmCross.Platforms.Ios.Core;
using TipCalc.Shared;
using UIKit;

namespace TipCalc.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
        public override void FinishedLaunching(UIApplication application)
        {
            base.FinishedLaunching(application);
        }
    }
}

