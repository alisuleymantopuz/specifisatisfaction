﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern.Specifications
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        public ISpecification<T> Specification { get; private set; }

        public NotSpecification(ISpecification<T> specification)
        {
            Specification = specification;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return !this.Specification.IsSatisfiedBy(o);
        }
    }
}
