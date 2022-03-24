using Checkout.Payments.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Payments.Services
{
    public interface IValidationService
    {
        bool Validate(CardInfo cardInfo, out string error);
    }
}
