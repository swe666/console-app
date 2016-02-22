using System;
using System.Collections.Generic;
using Application.Interfaces;

namespace Application
{
    public class OrderHandler : IOrderHandler
    {
        public bool ValidateOrder(Order order)
        {
            return true;
        }
    }
}
