namespace FactoryExample
{
    public class CheesePizza : PizzaBase
    {
        public override string AddCheese()
        {
            return "Adding cheese to the cheese pizza";
        }

        public override string AddSauce()
        {
            return "Adding sauce to the cheese pizza.";
        }

        public override string BakePizza()
        {
            return "Baking cheese pizza";
        }
    }
}