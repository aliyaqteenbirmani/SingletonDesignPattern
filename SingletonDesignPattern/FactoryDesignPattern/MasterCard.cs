using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.FactoryDesignPattern
{
    public class MasterCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2500;
        }

        public string GetCardType()
        {
            return "Standard Chartered Mastercard";
        }

        public int GetCreditLimit()
        {
            return 40000;
        }
    }
}
