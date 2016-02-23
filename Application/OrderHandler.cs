using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;

namespace Application
{
    public class OrderHandler : IOrderHandler
    {
        public bool ValidateOrder(string input)
        {
            List<string> dishTypes = new List<string>(input.Split(','));
            if (dishTypes.Distinct().Count() != dishTypes.Count())
            {
                if (dishTypes.First() == "morning")
                {
                    return ValidateMorningOrder(dishTypes);
                }
                else if (dishTypes.First() == "evening")
                {
                    return ValidateEveningOrder(dishTypes);
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }

        private bool ValidateMorningOrder(List<string> dishTypes)
        {
            if (dishTypes.Distinct().Count(x => x != "3") != dishTypes.Count(x => x != "3"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateEveningOrder(List<string> dishTypes)
        {

            if (dishTypes.Distinct().Count(x => x != "2") != dishTypes.Count(x => x != "2"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
