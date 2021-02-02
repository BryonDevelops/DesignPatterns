public class StarbuzzCoffee
{
    public static void Main(string args)
    {
        // Plain Espresso
        Beverage beverage = new Espresso();
        Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost}");

        // Duoble Mocha Dark Roast w/ Whip
        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost}");

    }
    
}

