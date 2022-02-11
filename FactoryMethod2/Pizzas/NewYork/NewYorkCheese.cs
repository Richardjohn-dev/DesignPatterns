namespace FactoryMethod2
{
    public class NewYorkCheese : Pizza
    {
        public NewYorkCheese()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
