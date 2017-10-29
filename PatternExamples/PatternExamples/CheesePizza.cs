namespace FactoryExample
{
    public class CheesePizza : PizzaBase
    {
        private bool hasCheese;
        private bool hasSauce;
        private bool hasToppings;
        private bool wasBaked;

        public override bool HasCheese
        {
            get => hasCheese;
            set => hasCheese = value;
        }

        public override bool HasSauce
        {
            get => hasSauce;
            set => hasSauce = value;
        }

        public override bool HasToppings
        {
            get => hasToppings;
            set => hasToppings = value;
        }

        public override bool WasBaked
        {
            get => wasBaked;
            set => wasBaked = value;
        }

        /// <inheritdoc />
        public override string AddCheese()
        {
            hasCheese = true;
            return "Adding cheese to the cheese pizza";
        }

        /// <inheritdoc />
        public override string AddSauce()
        {
            hasSauce = true;
            return "Adding sauce to the cheese pizza.";
        }

        public override string AddToppings()
        {
            hasToppings = true;
            return "Assing extra cheese to the pizza.";
        }

        /// <inheritdoc />
        public override string BakePizza()
        {
            wasBaked = true;
            return "Baking cheese pizza";
        }
    }
}