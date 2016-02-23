using System;
using System.Collections.Generic;
using Application;
using Application.Interfaces;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            DishHandler dh = GetDishHandler();
            OrderHandler oh = GetOrderHandler();
            Formats formats = GetFormats();
            while (true)
            {
                string input = Console.ReadLine();
                if (oh.ValidateOrder(input))
                {
                    Order order = dh.ParseOrder(input);
                    string formattedOrder = formats.FormatOrder(order);
                    Console.WriteLine(formattedOrder);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        static DishHandler GetDishHandler()
        {
            return new DishHandler(new DishRepository());
        }

        static Formats GetFormats()
        {
            return new Formats();
        }

        static OrderHandler GetOrderHandler()
        {
            return new OrderHandler();
        }
    }
}
