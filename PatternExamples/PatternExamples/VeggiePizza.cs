namespace FactoryExample
{
    public class VeggiePizza : PizzaBase
    {
        public override string AddCheese()
        {
            return "Adding cheese to the veggie pizza.";
        }

        public override string AddSauce()
        {
            return "Adding the sauce to the veggie pizza.";
        }

        public override string AddToppings()
        {
            return "Adding veggies to the pizza.";
        }

        public override string BakePizza()
        {
            return "Baking the veggie pizza.";
        }
    }
}