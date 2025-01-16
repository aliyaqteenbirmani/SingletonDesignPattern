using SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.AbstracFactory;
using SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteFactory
{
    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentTransfer CreateAuthorization() => new CreditCardAuthorization();


        public IPaymentTransfer CreateTransfer() => new CreditCardTransfer();
        
    }
}
