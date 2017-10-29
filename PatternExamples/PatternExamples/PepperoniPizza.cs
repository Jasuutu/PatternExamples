namespace FactoryExample
{
    public class PepperoniPizza : PizzaBase
    {
        /// <inheritdoc />
        public override string AddCheese()
        {
            return "Adding cheese to the pepperoni pizza.";
        }

        /// <inheritdoc />
        public override string AddSauce()
        {
            return "Adding sauce to the pepperoni pizza.";
        }

        public override string AddToppings()
        {
            return "Adding pepperonis to the pizza.";
        }

        /// <inheritdoc />
        public override string BakePizza()
        {
            return "Baking pizza.";
        }
    }
}