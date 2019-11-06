using ConsoleAppOOP.Models;
using System;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            new Car("BMW", "525i", "SBP704123123");

            //Car[] cars = { new Car("BMW", "525i", "SBP704"), new Car("Volvo", "745", "Skrott") };

            //foreach (Car aCar in cars)
            //{
            //    //Console.WriteLine(aCar.ToString());// same as below
            //    Console.WriteLine(aCar);
            //}

            //Console.Write("Select Car with number to see more information.\nSelection: ");
            //int selection = -1;

            //if (int.TryParse(Console.ReadLine(), out selection) && selection > 0)
            //{
            //    Console.WriteLine("valid input");
            //    foreach (var item in cars)
            //    {
            //        if (item.Id == selection)
            //        {
            //            Console.WriteLine(item.Info());
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}
        }
    }
}
