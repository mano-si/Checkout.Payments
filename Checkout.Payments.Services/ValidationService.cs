using Checkout.Payments.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Checkout.Payments.Services
{
    public class ValidationService : IValidationService
    {
        private const string _cardPattern = @"^\d{16}$";
        private const string _cvvPattern = @"^\d{3}$";
        public bool Validate(CardInfo cardInfo, out string error)
        {
            error = "";

            if (!Regex.IsMatch(cardInfo.CardNumber, _cardPattern))
            {
                error = "Error parsing card number. Invalid Card Number";
                return false;
            }

            if (cardInfo.ExpiryDate.Date >= DateTime.Today)
            {
                error = "Card Expired";
                return false;
            }

            if (cardInfo.Amount <= 0)
            {
                error = "Invalid Amount";
                return false;
            }

            if (!Regex.IsMatch(cardInfo.CVV, _cvvPattern))
            {
                error = "Error parsing card number. Invalid Card Number";
                return false;
            }

            return true;
        }
    }
}
