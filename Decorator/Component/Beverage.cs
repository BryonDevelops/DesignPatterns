// Component
public abstract class Beverage
{
    private BeverageSize size;
    private string description = "Unknown Beverage";
    public abstract double Cost { get; }

    public virtual string Description => description;

    public BeverageSize GetSize() => size;

    public void SetSize(BeverageSize value) => size = value;
}