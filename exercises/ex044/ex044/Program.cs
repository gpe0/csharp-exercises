using System;

namespace ex044
{
    //Nested classes
    class Car
    {
        private int wheels = 4;
        public Car()
        {
            Motor m = new Motor();
        }
        public void GetWheels()
        {
            Console.WriteLine("Your car has {0} wheels.", wheels);
        }
        public class Motor // The Motor class is nested in Car class
        {
            public void TurnOn()
            {
                Console.WriteLine("The car is now ON");
            }
        }
    }
       
    
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(); //This is the car
            c1.GetWheels();
            Car.Motor m1 = new Car.Motor(); //This is the actual motor
            m1.TurnOn();
        }
    }
}
