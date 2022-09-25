namespace StarBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage mocha = new Mocha(new Espresso());
            Console.WriteLine($"You odrered {((Mocha)mocha).Description} and it costs: {mocha.Cost()}");
        }
    }
}