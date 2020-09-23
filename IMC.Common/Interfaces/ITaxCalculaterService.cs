using System.Threading.Tasks;

namespace IMC.Common.Interfaces
{
    public interface ITaxCalculaterService
    {
        Task<double> RatesForLocationAsync(object request);
        Task<double> TaxForOrderAsync(object request);
    }
}
