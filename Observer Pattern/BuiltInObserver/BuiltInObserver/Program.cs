namespace BuiltInObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor temperatureMonitor = new TemperatureMonitor();
            temperatureMonitor.Subscribe(new TemperatureReporter());

            temperatureMonitor.GetTemperature();
        }
    }
}