using System;
using System.Linq;

namespace Application
{
    public class DishRepository : IDishRepository
    {
        public string GetDishName(string menuType, int dishInt)
        {
            if (menuType == "morning")
            {
                return GetMorningDishName(dishInt);
            }
            else if (menuType == "evening")
            {
                return GetEveningDishName(dishInt);
            }
            else
            {
                throw new ApplicationException("Unknown menu");
            }
        }
        private string GetEveningDishName(int dishInt)
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

        private string GetMorningDishName(int dishInt)
        {
            switch (dishInt)
            {
                case 1:
                    return "egg";
                case 2:
                    return "toast";
                case 3:
                    return "coffee";
                default:
                    throw new ApplicationException("Unknown dish");
            }
        }

        public Dish GetDish(Order order, string dishName)
        {
            Dish dish = order.Dishes.SingleOrDefault(x => x.DishName == dishName);
            return dish;
        }
    }
}