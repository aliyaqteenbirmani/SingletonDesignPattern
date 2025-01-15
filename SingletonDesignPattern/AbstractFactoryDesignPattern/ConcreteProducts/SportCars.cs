using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.ConcreteProducts
{
    public class SportCars : ICars
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportCar Details...");
        }
    }
}
