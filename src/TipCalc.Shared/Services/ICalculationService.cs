namespace TipCalc.Shared.Services
{
    public interface ICalculationService
    {
        decimal TipAmount(decimal subTotal, int generosity);
    }
}
