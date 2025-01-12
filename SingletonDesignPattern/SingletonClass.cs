using System;

namespace SingletonDesignPattern
{
    // for sibgleton design pattern class must be sealded
    sealed class SingletonClass
    {
        // using Lazy<T> for thread-safe and lazy initialization to make sure that each thread is getting the same instance
        private static readonly Lazy<SingletonClass> _instance = new Lazy<SingletonClass>(() => new SingletonClass());

        // constructor must be private to prevent from creating multiple instances
        private SingletonClass() { }

        // static globale-point access of instance
        public static SingletonClass GetInstance()
        {
            return _instance.Value;
        }

        // Method to print the HashCode of Singleton instance
        public void PrintMessage(string message)
        {
            Console.WriteLine($"{message} from Instance {GetHashCode()}");
        }
    }
}
