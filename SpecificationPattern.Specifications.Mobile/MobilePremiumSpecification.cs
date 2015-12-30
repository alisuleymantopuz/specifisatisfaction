using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecificationPattern.Domain;
using SpecificationPattern.Specifications;

namespace SpecificationPattern.Specifications.MobileSpecifications
{
    public class MobilePremiumSpecification : CompositeSpecification<Mobile>
    {
        private int _cost;

        public MobilePremiumSpecification(int cost)
        {
            this._cost = cost;
        }

        public override bool IsSatisfiedBy(Mobile o)
        {
            return o.Cost >= this._cost;
        }
    }
}
