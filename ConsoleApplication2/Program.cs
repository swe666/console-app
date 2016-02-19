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
            List<IOrder> orders = new List<IOrder>();
            while (true)
            {
                orders.Add(dh.ParseOrder(Console.ReadLine()));
            }
        }
    }
}
