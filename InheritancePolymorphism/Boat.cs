using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Boat : Vehicle // boat class inheriting protected fields from vehicle class
    {
        //added field
        private double waterDrag;

        //calling method
        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;//not being created here, but we have access to it from vehicle class; we're inheriting it
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        public Boat()
        {
            //default constructor
        }

        //calling method & overriding it for this class
        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag; // we're setting the distancedTraveled equal to the distrancedTraveled plus movementSpeed times waterDrag
        }

    }
}
