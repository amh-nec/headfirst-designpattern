using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public abstract class Beverage
    {
        string description = "Unknown Beverage";
        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public abstract double Cost();
    }
}
