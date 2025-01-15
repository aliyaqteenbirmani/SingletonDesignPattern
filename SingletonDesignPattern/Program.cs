using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SingletonDesignPattern.FactoryDesignPattern;
using System.Xml.Linq;
using SingletonDesignPattern.AbstractFactoryDesignPattern;
using SingletonDesignPattern.AbstractFactoryDesignPattern.ConcreteFactorys;


namespace SingletonDesignPattern
{
    public class Program
    {
        static void AccessSingleton()
        {
            SingletonClass singleton = SingletonClass.GetInstance();
            singleton.PrintMessage ($" Thread {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            //Parallel.Invoke(() => AccessSingleton(),
            //                 () => AccessSingleton()
            //                 );

            //Console.WriteLine("All threads have completed successfully");

            // Without Factory Design Pattern Implemention

            /*Console.Write("Enter Card Type: ");
            string cardType = Console.ReadLine();
/*
            ICreditCard card = null;
            if (cardType.ToLower() == "moneyback")
            {
                card = new Moneyback();
            }
            else if (cardType.ToLower() == "titanium")
            {
                card = new Titanium();
            }
            else if (cardType.ToLower() == "platinum")
            {
                card = new Platinum();
            }



            if (card != null)
            {
                Console.WriteLine($"CardType: {card.GetCardType()}");
                Console.WriteLine($"CreditCardLimit: {card.GetCreditLimit()}");
                Console.WriteLine($"AnnualCharge: {card.GetAnnualCharge()}");
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
           // } //

            // what are the issues with the above implementation?
            // First, Tight Coupling: btw the client (Program) class and the product classes, changes in one class we must make changes in the other classes too.
            // if we add a new credit card, we also need to modify the client code by adding an extra ELSE IF Condition which overhead the development
            // but also for testing, So lets overcome this problem by using Factory Design Pattern, for this we need to create a factory Class


            ICreditCard creditCard = CreditCardFactory.GetCreditCard(cardType);
            if(creditCard != null)
            {
                Console.WriteLine($"CardType: {creditCard.GetCardType()}");
                Console.WriteLine($"CreditCardLimit: {creditCard.GetCreditLimit()}");
                Console.WriteLine($"AnnualCharge: {creditCard.GetAnnualCharge()}");
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

            // now look the client (program) and the product classes are loosely coupled,
            // if we add any other type of credit card then we don't need to make changes in client code */

            IVehicleFactory regularVehivle = new RegularVehicleFactory();
            IBikes regularBike = regularVehivle.CreateBike();
            regularBike.GetDetails();
            ICars regularCar = regularVehivle.CreateCar();
            regularCar.GetDetails();

            IVehicleFactory sportVehivle = new SportVehicleFactory();
            IBikes sportBike = regularVehivle.CreateBike();
            sportBike.GetDetails();
            ICars sportCar = regularVehivle.CreateCar();
            sportCar.GetDetails();
            Console.ReadLine();
        }

    }
}
