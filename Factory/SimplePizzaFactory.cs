public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;

        switch (pizza.Type)
        {
            case "Cheese":
                pizza = new CheesePizza();
            case "Pepperoni":
                pizza = new PepperoniPizza();
            default:
                pizza = new CheesePizza();
        }

        return pizza;
    }
}