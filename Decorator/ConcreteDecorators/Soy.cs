public class Soy : CondimentDecorator
{
    Beverage beverage;

    public Soy(Beverage beverage) => this.beverage = beverage;

    public override string GetDescription() => beverage.GetDescription() + ", Soy";

    public override double Cost() => .25 + beverage.Cost();
}