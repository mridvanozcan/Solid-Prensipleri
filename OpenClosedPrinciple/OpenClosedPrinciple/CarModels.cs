using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class CarModels
    {
        public void modelShower(int CarCode, BrandModelChecker modelChecker)
        {
            if (modelChecker.brandCheck(CarCode) == false) { Console.WriteLine("No Car Brands Detected!"); }
            else
            {
                switch (CarCode)
                {
                    case 12:
                        Console.WriteLine("Corsa");
                        break;
                    case 33:
                        Console.WriteLine("Cruze");
                        break;

                    default:
                        Console.WriteLine("Car not Found!");
                        break;
                }
            }
        }
    }
}
