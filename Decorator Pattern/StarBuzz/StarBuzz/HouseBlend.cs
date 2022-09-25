using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class HouseBlend : Beverage
    {
        public override double Cost()
        {
            return 0.89;
        }

        public override string GetDescription()
        {
            return "House Blend Coffee"; 
        }
    }
}
