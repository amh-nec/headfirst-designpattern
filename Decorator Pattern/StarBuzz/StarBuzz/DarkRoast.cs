using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class DarkRoast : Beverage
    {
        public override double Cost()
        {
            return 0.99;
        }

        public override string GetDescription()
        {
            return "House Blend Coffee";
        }
    }
}
