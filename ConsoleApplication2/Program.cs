using System;
using System.Collections.Generic;
using Application;
using Application.Interfaces;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DishHandler dh = new DishHandler();
            while (true)
            {
                Console.WriteLine(dh.FormatOrder(dh.ParseOrder(Console.ReadLine())));
            }
        }
    }
}
