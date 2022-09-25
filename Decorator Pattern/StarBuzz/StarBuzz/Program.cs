namespace StarBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage mocha = new Whipe(new Mocha(new Mocha(new Espresso())));
            Console.WriteLine($"You odrered {mocha.GetDescription()} and it costs: {mocha.Cost()}");
        }
    }
}