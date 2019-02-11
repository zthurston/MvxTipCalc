using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TipCalc.Shared.ViewModels;
using UIKit;

namespace TipCalc.iOS.Views
{
    public partial class TipView : MvxViewController<TipViewModel>
    {
        public TipView() : base(nameof(TipView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var bindingSet = this.CreateBindingSet<TipView, TipViewModel>();
            bindingSet.Bind(TipLabel).To(vm => vm.Tip);
            bindingSet.Bind(SubTotalTextField).To(vm => vm.SubTotal);
            bindingSet.Bind(GenerositySlider).To(vm => vm.Generosity);
            bindingSet.Bind(GenerosityTextField).To(vm => vm.Generosity);
            bindingSet.Apply();

            // close keyboard when the screen is tapped outside 
            // the bounds of the SubTotalTextField
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                SubTotalTextField.ResignFirstResponder();
            }));
        }
    }
}

