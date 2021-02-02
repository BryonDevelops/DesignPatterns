public class Whip : CondimentDecorator
{
    Beverage beverage;

    public Whip(Beverage beverage) => this.beverage = beverage;

    public override string GetDescription() => beverage.GetDescription() + ", Whip";

    public override double Cost() => .20 + beverage.Cost();
}