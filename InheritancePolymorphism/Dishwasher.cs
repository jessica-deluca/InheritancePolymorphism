using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Dishwasher : Appliances
    {
        public override void Clean()
        {
            Console.WriteLine("I'm clean now");
        }


    }
}
