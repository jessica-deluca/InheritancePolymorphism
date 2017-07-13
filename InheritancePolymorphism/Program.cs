using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(2, 500, "white and yellow", 70.0d, 0.78d);
            boat1.Move(); // uses the Move method we overrided for boat
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled()); // 70 + 70 * .78 = 109.2 // gets GetDistanceTraveled method from vehicle

            Automobile car1 = new Automobile(4, 20, 4, 5, 500, "red", 260);
            car1.Move(); // uses the Move method from vehicle

            car1.Color = "gold"; // this changes the property
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled()); // gets GetDistanceTraveled method from vehicle

            Aircraft plane1 = new Aircraft(100, 1000000, "purple", 600);
            plane1.Move();
            plane1.Move();
            Console.WriteLine("Aircraft " + plane1.GetDistanceTraveled()); // Altitude 20000- 1200


        }
    }
}
