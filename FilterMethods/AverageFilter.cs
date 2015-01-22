using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterMethods
{
    internal class AverageFilter : Filter
    {
        public AverageFilter(int length)
            : base(length)
        {

        }

        public override double Calculate()
        {
            return base.buffer.Average();
        }
    }
}
