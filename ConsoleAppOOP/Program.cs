using ConsoleAppOOP.Models;
using System;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW","525i","SBP704");

            Console.WriteLine(myCar.Info());

            Car ericsCar = new Car("Volvo","745","Skrott");

            Console.WriteLine(ericsCar.ToString());
        }
    }
}
