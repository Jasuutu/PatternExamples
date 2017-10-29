namespace FactoryExample
{
    public class CheesePizza : PizzaBase
    {
        /// <inheritdoc />
        public override string AddCheese()
        {
            return "Adding cheese to the cheese pizza";
        }

        /// <inheritdoc />
        public override string AddSauce()
        {
            return "Adding sauce to the cheese pizza.";
        }

        public override string AddToppings()
        {
            return "Assing extra cheese to the pizza.";
        }

        /// <inheritdoc />
        public override string BakePizza()
        {
            return "Baking cheese pizza";
        }
    }
}