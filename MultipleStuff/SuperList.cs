using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public SuperList() : base()
        {

        }
        public void GetMinMax1(out double min, out double max)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            min = this[0];
            max = this[0];

            foreach (double val in this)
            {
                if (val < min)
                {
                    min = val;
                }
                if (val > max)
                {
                    max = val;
                }
            }
        }

        public readonly struct MinMaxResult
        {
            public readonly double Min {get;}
            public readonly double Max {get;}

            public MinMaxResult(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public MinMaxResult GetMinMax2()
        {

            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            double min = this[0];
            double max = this[0];

            foreach (double val in this)
            {
                if (val < min)
                {
                    min = val;
                }
                if (val > max)
                {
                    max = val;
                }
            }
            return new MinMaxResult(min, max);

        }
    }
}