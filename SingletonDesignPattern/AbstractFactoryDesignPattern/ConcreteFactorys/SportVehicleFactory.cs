using SingletonDesignPattern.AbstractFactoryDesignPattern.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern.ConcreteFactorys
{
    public class SportVehicleFactory : IVehicleFactory
    {
        public IBikes CreateBike()
        {
            return new SportBikes();
        }

        public ICars CreateCar()
        {
            return new RegularCars();
        }
    }
}
