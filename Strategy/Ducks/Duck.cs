public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public IQuackBehavior QuackBehavior
    {
        get
        {
            return quackBehavior;
        }
        set
        {
            quackBehavior = value;
        }
    }

    public IFlyBehavior FlyBehaviour
    {
        get
        {
            return flyBehavior;
        }
        set
        {
            flyBehavior = value;
        }
    }

    public abstract object Display();

    public object PerformFly() => FlyBehaviour.Fly();

    public object PerformQuack()=> QuackBehavior.Quacking();

    public string Swim() => "All ducks float, even toys ...";
}