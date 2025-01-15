using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.FactoryDesignPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if (cardType.ToLower() == "moneyback")
            {
                creditCard = new Moneyback();
            }
            else if (cardType.ToLower() == "titanium")
            {
                creditCard = new Titanium();
            }
            else if (cardType.ToLower() == "platinum")
            {
                creditCard = new Platinum();
            }
            return creditCard;
        }
    }
}
