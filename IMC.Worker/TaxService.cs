using IMC.Common.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Worker
{
    public class TaxService
    {
        private readonly ILogger<TaxService> _logger;
        private readonly ITaxCalculaterService _taxCalculater;

        public TaxService(ILogger<TaxService> logger, ITaxCalculaterService taxCalculater)
        {
            _logger = logger;
            _taxCalculater = taxCalculater;
        }

        public async Task<double> RatesForLocation(object request)
        {
            return await _taxCalculater.RatesForLocationAsync(request);
        }

        public async Task<double> TaxForOrder(object request)
        {
            return await _taxCalculater.TaxForOrderAsync(request);
        }
    }
}
