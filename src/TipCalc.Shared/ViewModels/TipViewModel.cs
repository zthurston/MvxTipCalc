using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using TipCalc.Shared.Services;

namespace TipCalc.Shared.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;

        public TipViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            _subTotal = 100;
            _generosity = 18;

            Recalculate();
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(nameof(Generosity));

                Recalculate();
            }
        }

        private decimal _subTotal;
        public decimal SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(nameof(SubTotal));

                Recalculate();
            }
        }

        private decimal _tip;
        public decimal Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(nameof(Tip));
            }
        }

        private void Recalculate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }
    }
}
