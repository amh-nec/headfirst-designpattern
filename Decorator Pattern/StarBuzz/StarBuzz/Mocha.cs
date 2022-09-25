using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class Mocha : CondimentDecorator
    {
        Beverage Beverage { get; set; }
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return Beverage.Description + ", Mocha";
            }
        }

        public override double Cost()
        {
            return Beverage.Cost()+0.2;
        }
    }
}
