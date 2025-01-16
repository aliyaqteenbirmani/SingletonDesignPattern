using SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.AbstracFactory;
using SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample.ConcreteFactory
{
    public class PayPalPaymentFactory : IPaymentFactory
    {
        public IPaymentTransfer CreateAuthorization() => new PaypalAuthorization();
        public IPaymentTransfer CreateTransfer() => new PayPalTransfer();
    }
}
