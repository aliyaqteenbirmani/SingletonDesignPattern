using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.FactoryDesignPattern
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 53000;
        }
    
    }
}
