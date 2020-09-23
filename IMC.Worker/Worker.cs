using System;
using System.Threading;
using System.Threading.Tasks;
using IMC.Common.Interfaces;
using IMC.TaxJar.Client;
using IMC.TaxJar.Client.Requests;
using IMC.TaxJar.Client.Responses;
using IMC.Worker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IMCSalesTaxService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly TaxService _taxService;

        public Worker(ILogger<Worker> logger, TaxService taxService)
        {
            _logger = logger;
            _taxService = taxService;
        }
        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                var taxForLocation = await _taxService.RatesForLocation(new RatesForLocationRequest("33162"));
                var taxForOrder = await _taxService.TaxForOrder(new TaxForOrderRequest()
                {
                    Amount = "15",
                    Shipping = "1.5",
                    ToCountry = "US",
                    ToState = "CA",
                    ToZip = "90002"
                });

                _logger.LogInformation($"Total tax for location: {taxForLocation}");
                _logger.LogInformation($"Total tax for order: {taxForOrder}");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
