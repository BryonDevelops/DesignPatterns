public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";

        toppings.Add("Shredded Mozzarella Cheese");
    }

    public override string Cut()
    {
        //base.Cut ();
        return "Cutting the pizza into square slices \n";
    }
}