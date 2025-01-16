using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteProduct
{
    public class PaypalAuthorization : IPaymentTransfer
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing Payment of {amount} via PayPal...");
            return true;
        }
    }
}
