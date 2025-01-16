using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteProduct
{
    public class CreditCardAuthorization : IPaymentTransfer
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine( $" Authorization payment of {amount} via Credit Card...");
            return true;
        }
    }
}
