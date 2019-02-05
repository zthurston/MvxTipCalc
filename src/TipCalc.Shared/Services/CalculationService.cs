using System;
namespace TipCalc.Shared.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal TipAmount(decimal subTotal, int generosity)
        {
            return subTotal * (generosity / 100m);
        }
    }
}
