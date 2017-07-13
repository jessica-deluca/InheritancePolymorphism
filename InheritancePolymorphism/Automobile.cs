using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Automobile : Vehicle // automobile class inheriting protected fields from vehicle class
    {
        //added fields
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        //properties
        public int NumberOfWheels { get; }
        public int NumberOfDoors { get; }
        public float WheelSize { get; }

        //constructors
        public Automobile()
        {
            //default constructor
        }

        public Automobile(int numberOfWheels, int wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }

    }
}
