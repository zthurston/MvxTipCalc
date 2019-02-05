using System;
using MvvmCross;
using MvvmCross.ViewModels;
using TipCalc.Shared.Services;
using TipCalc.Shared.ViewModels;

namespace TipCalc.Shared
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
