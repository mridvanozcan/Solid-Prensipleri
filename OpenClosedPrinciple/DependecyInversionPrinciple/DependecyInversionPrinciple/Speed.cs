using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInversionPrinciple
{
    public class Speed : Car
    {
        public Car car { get; set; }

        public Speed(Car car)
        {
            this.car = car;
        }

        public void drive(int go)
        {
            car.drive(go);
        }
    }
}
