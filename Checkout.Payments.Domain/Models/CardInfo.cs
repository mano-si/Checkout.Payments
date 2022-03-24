using Checkout.Payments.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Checkout.Payments.Domain.Models
{
    public class CardInfo : PaymentInfo
    {
        public string CardNumber { get; set; }

        public DateTime ExpiryDate { get; set; }

        public double Amount { get; set; }

        public string CVV { get; set; }

        public Currency Currency { get; set; }
    }
}
