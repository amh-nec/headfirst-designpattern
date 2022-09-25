using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver
{
    public class FullForcastDisplay : IObserver, IDisplay
    {
        float Temp { get; set; }
        float Hum { get; set; }
        float Pres { get; set; }
        public void Display()
        {
            Console.WriteLine($"Temprature: {Temp} -- Humidity: {Hum} -- Pressure: {Pres}.");
        }

        public void Update(ISubject subject)
        {
            Subject weather = (Subject)subject;
            Temp = weather.Temprature;
            Hum = weather.Humidity;
            Pres = weather.Pressure;
        }
    }
}
