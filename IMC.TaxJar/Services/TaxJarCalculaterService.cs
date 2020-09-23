using IMC.Common.Interfaces;
using IMC.TaxJar.Client;
using IMC.TaxJar.Client.Requests;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMC.TaxJar.Services
{
    public class TaxJarCalculaterService : ITaxCalculaterService
    {
        private readonly ILogger<TaxJarCalculaterService> _logger;
        private readonly TaxJarClient _taxJarClient;

        public TaxJarCalculaterService(ILogger<TaxJarCalculaterService> logger, TaxJarClient taxJarClient) 
        {
            _logger = logger;
            _taxJarClient = taxJarClient;
        }

        public async Task<double> RatesForLocationAsync(object request)
        {
            try
            {
                var ratesForLocationResponse = await _taxJarClient.RatesForLocation(request);

                if (!Double.TryParse(ratesForLocationResponse.Rate.CombinedRate, out double tax))
                    throw new ArgumentException($"Coudle not parse {ratesForLocationResponse.Rate.CombinedRate} as a double");

                return tax;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<double> TaxForOrderAsync(object request)
        {
            try
            {
                var taxForOrderResponse = await _taxJarClient.TaxForOrder(request);

                if (!Double.TryParse(taxForOrderResponse.Tax.Rate, out double tax))
                    throw new ArgumentException($"Coudle not parse {taxForOrderResponse.Tax.Rate} as a double");

                return tax;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
