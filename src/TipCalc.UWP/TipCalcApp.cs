using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace TipCalc.UWP
{
	public abstract class TipCalcApp : MvxApplication<MvxWindowsSetup<Shared.App>, Shared.App>
	{
		public TipCalcApp()
		{
		}
	}
}
