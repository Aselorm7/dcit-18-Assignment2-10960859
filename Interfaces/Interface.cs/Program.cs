using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    // Define the interface IMovable
    interface IMovable
    {
        void Move();
    }

    // Class Car that implements IMovable
    class Car : IMovable
    {
        // Implement the Move method
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle that implements IMovable
    class Bicycle : IMovable
    {
        // Implement the Move method
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Car
            Car myCar = new Car();

            // Create an instance of Bicycle
            Bicycle myBicycle = new Bicycle();

            // Call the Move method on each instance
            myCar.Move();       // Output: Car is moving
            myBicycle.Move();   // Output: Bicycle is moving
        }
    }
}
