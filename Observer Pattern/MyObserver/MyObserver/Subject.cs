using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver
{
    public class Subject : ISubject
    {
        public float Temprature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Obsercer attached");
            _observers.Add(observer);   
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Observer detached");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void UpdateWeather(float temprature, float humidity, float pressure)
        {
            Temprature = temprature;
            Humidity = humidity;
            Pressure = pressure;

            this.Notify();
        }
    }
}
