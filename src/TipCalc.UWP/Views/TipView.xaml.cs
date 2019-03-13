using System;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using TipCalc.Shared.ViewModels;

namespace TipCalc.UWP.Views
{
	[MvxViewFor(typeof(TipViewModel))]
	public sealed partial class TipView : MvxWindowsPage
	{
		public TipView()
		{
			InitializeComponent();
		}
	}
}
