using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInversionPrinciple
{
    class Slow : Car
    {
        public void drive(int go)
        {
            if (go<100)
            {
                Console.WriteLine("This car is too slow: " + go + " Km/h");
            }
            else
            {
                Console.WriteLine("This car is too fast. You are in wrong place");
            }
            
        }
    }
}
