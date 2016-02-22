using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;

namespace Application
{
    public class DishHandler
    {
        private readonly IDishRepository _repository;

        public DishHandler(IDishRepository repository)
        {
            _repository = repository;
        }

        public Order ParseOrder(string input)
        {
            Order order = new Order();
            List<string> dishTypes = new List<string>(input.Split(','));
            string menuType = GetMenuType(dishTypes.First());
            dishTypes.RemoveAt(0);
            if (menuType != null)
            {
                foreach (string dishType in dishTypes)
                {
                    string dishName = "";
                    int dishInt = 0;
                    int.TryParse(dishType, out dishInt);
                    try
                    {
                        dishName = _repository.GetDishName(menuType, dishInt);
                    }
                    catch (ApplicationException e)
                    {
                        return null;
                    }
                    Dish dish = _repository.GetDish(order, dishName);
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
            else
            {
                return null;
            }
        }

        public string GetMenuType(string input)
        {
            switch (input)
            {
                case "morning":
                    return "morning";
                case "evening":
                    return "evening";
                default:
                    return null;
            }
        } 
    }
}
