namespace FactoryMethod2
{
    public class NewYorkPeperoni : Pizza
    {
        public NewYorkPeperoni()
        {
            Name = "NY Style Pepperoni Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Garlic");
            Toppings.Add("Onion");
            Toppings.Add("Mushrooms");
            Toppings.Add("Red Pepper");
        }
    }
}
