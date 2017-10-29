namespace FactoryExample
{
    public class PepperoniPizza : PizzaBase
    {
        public override string AddCheese()
        {
            return "Adding cheese to the pepperoni pizza.";
        }

        public override string AddSauce()
        {
            return "Adding sauce to the pepperoni pizza.";
        }

        public override string BakePizza()
        {
            return "Baking pizza.";
        }
    }
}