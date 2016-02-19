using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;

namespace Application
{
    public class DishHandler : IDishHandler, IOrder
    {
        public List<Dish> Dishes { get; set; }

        public IOrder ParseOrder(string input)
        {
            IOrder order = new Order();
            string[] dishTypeStrings = input.Split(',');
            foreach(string dishType in dishTypeStrings)
            {
                int dishInt = 0;
                int.TryParse(dishType, out dishInt);
                string dishName = GetDishName(dishInt);
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
