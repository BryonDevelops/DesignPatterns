public class Mocha : CondimentDecorator
{
    Beverage beverage;

    public Mocha(Beverage beverage) => this.beverage = beverage;

    public override string GetDescription() => beverage.GetDescription() + ", Mocha";

    public override double Cost => GetSize(base.Size);

    private double GetSize(BeverageSize size)
    {
        switch(size)
        {
            case BeverageSize.TALL:
                return Convert.ToDouble(".10") +
                    beverage.Cost();
            case BeverageSize.GRANDE:
                return Convert.ToDouble(".15") +
                    beverage.Cost();
            case BeverageSize.VENTI:
                return Convert.ToDouble(".20") +
                    beverage.Cost();
            case BeverageSize.TRENTA:
                return Convert.ToDouble(".25") +
                    beverage.Cost();
            default:
                return .20;
        }
    }

}