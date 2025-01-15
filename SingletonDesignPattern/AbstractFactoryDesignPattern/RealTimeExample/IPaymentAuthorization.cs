using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.RealTimeExample
{
    public interface IPaymentAuthorization
    {
        bool AuthorizePayment(decimal amount);
    }

    public interface IPaymentTransfer
    {
        bool Transfer(decimal amount);
    }


}
