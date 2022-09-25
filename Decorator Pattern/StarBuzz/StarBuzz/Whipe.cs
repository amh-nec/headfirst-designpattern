using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class Whipe : CondimentDecorator
    {
        Beverage _beverage { get; set; }
        public Whipe(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double Cost()
        {
            return _beverage.Cost() + 0.1;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription()+ " , With Whip cream";
        }
    }
}
