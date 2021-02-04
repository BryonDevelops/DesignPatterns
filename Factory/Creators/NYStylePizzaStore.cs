public class NYStylePizzaStore : PizzaStore
{
    public Pizza CreatePizza(string item)
    {
        switch (item)
        {
            case "Cheese":
                return new CheesePizza();
            case "Pepperoni":
                return new PepperoniPizza();
            case "Veggie":
                return new VeggiePizza();
            default:
                return null;
        }
    }
}