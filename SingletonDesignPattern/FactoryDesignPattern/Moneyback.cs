using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.FactoryDesignPattern
{
    public class Moneyback : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 1500;
        }
    
    }
}
