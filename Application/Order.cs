using System.Collections.Generic;
using Application.Interfaces;

namespace Application
{
    public class Order : IOrder
    {
        public Order()
        {
            Dishes = new List<Dish>();
        }

        public List<Dish> Dishes { get; set; }
    }
}
