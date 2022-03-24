using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkout.Payments.Domain.Models;
using Checkout.Payments.Services;
using Checkout.Payments.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkout.Payments.Controllers
{
    [Route("payments")]
    [ApiController]
    public class PaymentsIngestionController : ControllerBase
    {
        private readonly IPaymentsInjestionService _paymentsInjestionService;
        private readonly IValidationService _validationService;

        public PaymentsIngestionController(IPaymentsInjestionService paymentsInjestionService, IValidationService validationService)
        {
            _paymentsInjestionService = paymentsInjestionService;
            _validationService = validationService;

        }

        [HttpPost]
        [Route("card")]
        public IActionResult PostRequestForCardPayment(CardInfo cardInfo)
        {
            string error = "";

            if(!_validationService.Validate(cardInfo, out error))
            {
                return BadRequest(error);
            }

            _paymentsInjestionService.ProcessPayment();
            return null;
        }
        
        [HttpGet]
        [Route("transaction")]
        public IActionResult GetTransactionInfoById()
        {
            return null;
        }

        [HttpGet]
        [Route("last-transaction")]
        public IActionResult GetLastTransactionByType()
        {
            return null;
        }
    }
}
