namespace FactoryMethod2
{
    public class NewYorkVeggie : Pizza
    {
        public NewYorkVeggie()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Garlic");
            Toppings.Add("Onion");
            Toppings.Add("Mushrooms");
            Toppings.Add("Red Pepper");
        }
    }
}
