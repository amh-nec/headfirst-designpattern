namespace MyObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            TempDisplay tempDisplay = new TempDisplay();
            FullForcastDisplay fullForcastDisplay = new FullForcastDisplay();   

            subject.Attach(tempDisplay);
            subject.Attach(fullForcastDisplay);

            subject.UpdateWeather(30, 86, 1001);

            tempDisplay.Display();
            fullForcastDisplay.Display();

            subject.Detach(tempDisplay);

            subject.UpdateWeather(35, 76, 1004);

            tempDisplay.Display();
            fullForcastDisplay.Display();
        }
    }
}