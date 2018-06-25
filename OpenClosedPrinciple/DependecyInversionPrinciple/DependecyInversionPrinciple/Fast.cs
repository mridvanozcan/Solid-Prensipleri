using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInversionPrinciple
{
    public class Fast : Car
    {
        public void drive(int go)
        {
            if (go>=100)
            {
                Console.WriteLine("This Car is Too Fast: "+go+ " Km/h");
            }
            else
            {
                Console.WriteLine("Oww men this car is sloww :/");

            }
            
        }
    }
}
