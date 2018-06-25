using System;

namespace LiskovsSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var animal = new Animal
            {
                Name = "Cat",
                Age = 12,
                MF = "M"
            };

            Male male = new Male();
            Female female = new Female();



           Console.WriteLine( male.ShowAnimal(animal));
            Console.WriteLine(female.ShowAnimal(animal));

            Console.WriteLine("Program Sonu!");
            Console.ReadKey();

            

        }
    }
}
