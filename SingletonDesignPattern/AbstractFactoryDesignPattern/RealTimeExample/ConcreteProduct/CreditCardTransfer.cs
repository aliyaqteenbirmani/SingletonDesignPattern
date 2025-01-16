using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteProduct
{
    public class CreditCardTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine($"Transferring Payment of {amount} via Credit Card...");
            return true;
        }
    }
}
