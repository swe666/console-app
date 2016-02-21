using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;

namespace Application
{
    public class DishHandler
    {

        public Order ParseOrder(string input)
        {
            Order order = new Order();
            string[] dishTypeStrings = input.Split(',');
            foreach(string dishType in dishTypeStrings)
            {
                string dishName = "";
                int dishInt = 0;
                int.TryParse(dishType, out dishInt);
                try
                {
                    dishName = GetDishName(dishInt);
                }
                catch (ApplicationException e)
                {
                    return null;
                }
                Dish dish = order.Dishes.SingleOrDefault(x => x.DishName == dishName);
                if (dish == null)
                {
                    dish = new Dish {DishName = dishName, Count = 1};
                    order.Dishes.Add(dish);
                }
                else
                {
                    dish.Count++;
                }
            }

            return order;
        }

        public string FormatOrder(Order order)
        {
            string orders = "";
            if (order == null)
            {
                return "error";
            }
            else
            {
                foreach (var dish in order.Dishes.Select((value, i) => new { i, value }))
                {
                    orders += dish.value.DishName;
                    if (dish.value.Count > 1)
                    {
                        orders += "(x" + dish.value.Count + ")";
                    }
                    if (order.Dishes.Count != dish.i + 1)
                    {
                        orders += ", ";
                    }
                }
                return orders;
            }
            
        }

        public string GetDishName(int dishInt)
        {
            switch (dishInt)
            {
                case 1:
                    return "steak";
                case 2:
                    return "potato";
                case 3:
                    return "wine";
                case 4:
                    return "cake";
                default:
                    throw new ApplicationException("Unknown dish");
            }
        }
    }
}
