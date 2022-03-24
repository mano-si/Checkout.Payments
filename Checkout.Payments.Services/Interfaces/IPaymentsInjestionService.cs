using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Payments.Services.Interfaces
{
    public interface IPaymentsInjestionService : IService
    {
        void ProcessPayment();
    }
}
