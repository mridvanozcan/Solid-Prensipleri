using System;

namespace DependecyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Starting \n");

            Fast fast = new Fast();

            fast.drive(200);

            var fas = new Speed(fast);

            fas.drive(10);

            Console.ReadKey();
        }
    }
}
