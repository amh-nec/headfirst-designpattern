using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver
{
    public class TempDisplay : IObserver, IDisplay
    {
        float Temp { get; set; }
        public void Display()
        {
            Console.WriteLine($"The temprature is : {Temp}");
        }

        public void Update(ISubject subject)
        {
            Temp = ((Subject)subject).Temprature;
        }
    }
}
