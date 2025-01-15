using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.ConcreteProducts
{
    public class RegularBikes : IBikes
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details...");
        }
    }
}
