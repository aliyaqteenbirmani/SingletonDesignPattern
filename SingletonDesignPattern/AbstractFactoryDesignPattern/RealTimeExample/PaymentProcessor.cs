using SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.AbstracFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample
{
    public class PaymentProcessor
    {
        private readonly IPaymentTransfer _authorization;
        private readonly IPaymentTransfer _transfer;

        public PaymentProcessor(IPaymentFactory factory)
        {
            _authorization = factory.CreateAuthorization();
            _transfer = factory.CreateTransfer();
        }

        public bool ProcessPayment(decimal amount)
        {
            if (_authorization.AuthorizePayment(amount))
            {
                return _transfer.Transfer(amount);
            }
            return false;
        }
    }
}
