using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain
{
    public class Drink
    {
        public Drink(DrinkBrandName drinkBrandName, DrinkType drinkType, decimal cost = 0)
        {
            this.Cost = cost;
            this.DrinkBrandName = drinkBrandName;
            this.DrinkType = drinkType;
        }

        public string GetDescription()
        {
            return "The drink is of brand : " + this.DrinkBrandName + " and of type : " + this.DrinkType;
        }


        public decimal Cost { get; set; }
        public DrinkBrandName DrinkBrandName { get; set; }
        public DrinkType DrinkType { get; set; }
    }
}
