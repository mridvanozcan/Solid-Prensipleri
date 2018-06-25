using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car opel = new Car("Opel","Corsa",12);
            Car Chw = new Car("Chevrolet","Cruze",33);
            Car car1 = new Car("1221", "asdwad", 1234);

            CarModels car = new CarModels();

            GermanBradsCheckers gCheck = new GermanBradsCheckers();
            UsaBrandsCheckers usa = new UsaBrandsCheckers();

            car.modelShower(opel.ModelCode, gCheck);
            car.modelShower(Chw.ModelCode,usa);
            car.modelShower(car1.ModelCode, gCheck);

            Console.ReadKey();
        }
    }
}
