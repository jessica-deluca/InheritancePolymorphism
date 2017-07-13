using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Aircraft : Vehicle // aircraft class inheriting protected fields from vehicle class
    {
        //added field
        private double altitude;

        //property
        public double Altitude { get; }

        //constructors
        public Aircraft()
        {
            //default constructor
        }

        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            altitude = 0.0d;
        }

        public override void Move() //aircraft moves similarly to vehicle, but it also moves differently
        {
            altitude += 10000.0d;
            base.Move(); // base refers to base class' Move method; keep what it's in vehicle but also do something different
        }

        public override string GetDistanceTraveled()
        {
            return "Altitude " + altitude + "-" + base.GetDistanceTraveled();
        }


    }
}
