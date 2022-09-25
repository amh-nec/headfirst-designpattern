using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    internal abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("I'm swimming....");
        }
        public void PerformFLy()
        {
            FlyBehavior.Fly();
        }
        public void PerformQauck()
        {
            QuackBehavior.Quack();
        }


    }
}
