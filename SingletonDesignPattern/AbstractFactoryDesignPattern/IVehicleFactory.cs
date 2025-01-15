using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern
{
    public interface IVehicleFactory
    {
        IBikes CreateBike();
        ICars CreateCar();
    }
}
