using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class Formats : IFormats
    {
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
    }
}
