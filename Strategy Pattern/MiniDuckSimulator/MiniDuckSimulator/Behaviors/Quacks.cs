using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    internal class Quacks : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack...Quack...Quack...Quack...Quack...");
        }
    }
}
