namespace FactoryExample
{
    public static class PizzaFactory
    {
        public static PizzaBase MakePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    var cheesePizza = new CheesePizza();
                    cheesePizza.AddCheese();
                    cheesePizza.AddSauce();
                    cheesePizza.AddToppings();
                    cheesePizza.BakePizza();
                    return cheesePizza;
                case "Pepperoni":
                    var pepperoniPizza = new CheesePizza();
                    pepperoniPizza.AddCheese();
                    pepperoniPizza.AddSauce();
                    pepperoniPizza.AddToppings();
                    pepperoniPizza.BakePizza();
                    return pepperoniPizza;
                case "Veggie":
                    var veggiePizza = new CheesePizza();
                    veggiePizza.AddCheese();
                    veggiePizza.AddSauce();
                    veggiePizza.AddToppings();
                    veggiePizza.BakePizza();
                    return veggiePizza;
                default:
                    return null;
            }
        }
    }
}