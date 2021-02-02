/// <summary>
/// Pizza info
/// </summary>
public abstract class Pizza
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }

    List<string> toppings = new();

    public string Prepare()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Preparing " + name + "\n");
        sb.Append("Tossing " + dough + "\n");
        sb.Append("Adding " + sauce + "\n");
        sb.Append("Adding toppings:" + "\n");

        foreach(string topping in toppings)
        {
            sb.Append("\t" + topping + "\n");
        }

        return sb.ToString();
    }

    public virtual string Bake() => "Bake for 25 minutes at 350 \n";
    public string Cut() => "Cutting the pizza into diagonal slices \n";
    public string Box() => "Place pizza in official PizzaStore box \n";
}