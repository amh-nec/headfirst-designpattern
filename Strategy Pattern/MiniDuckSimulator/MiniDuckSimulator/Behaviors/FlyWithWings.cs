﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    internal class FlyWithWings:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings....");
        }
    }
}
