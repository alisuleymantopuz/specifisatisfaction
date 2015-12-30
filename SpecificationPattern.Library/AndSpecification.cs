﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern.Specifications
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public ISpecification<T> LeftSpecification { get; private set; }
        public ISpecification<T> RightSpecification { get; private set; }

        public AndSpecification(ISpecification<T> rightSpecification, ISpecification<T> leftSpecification)
        {
            LeftSpecification = leftSpecification;
            RightSpecification = rightSpecification;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return this.LeftSpecification.IsSatisfiedBy(o)
            && this.RightSpecification.IsSatisfiedBy(o);
        }
    }
}
