public class Milk : CondimentDecorator
{
    Beverage beverage;
    public Milk(Beverage beverage, double cost, string description) : base(beverage) {
        this.beverage = beverage;
        this.Cost = cost;
        this.Description = description;
    }

    public string Description = beverage.Description + ", Milk";
    public double Cost = beverage.Cost + .20;
}