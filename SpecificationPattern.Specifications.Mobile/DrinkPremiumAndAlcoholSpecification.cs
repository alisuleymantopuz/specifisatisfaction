using SpecificationPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specifications.MobileSpecifications
{
    public class DrinkPremiumAndAlcoholSpecification : CompositeSpecification<Drink>
    {
        public override bool IsSatisfiedBy(Drink o)
        {
            return o.DrinkType == DrinkType.Alcohol && o.Cost >= 75;
        }
    }
}
