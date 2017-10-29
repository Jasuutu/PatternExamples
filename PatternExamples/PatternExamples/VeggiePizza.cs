namespace FactoryExample
{
    public class VeggiePizza : PizzaBase
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

        public override string AddCheese()
        {
            hasCheese = true;
            return "Adding cheese to the veggie pizza.";
        }

        public override string AddSauce()
        {
            hasSauce = true;
            return "Adding the sauce to the veggie pizza.";
        }

        public override string AddToppings()
        {
            hasToppings = true;
            return "Adding veggies to the pizza.";
        }

        public override string BakePizza()
        {
            wasBaked = true;
            return "Baking the veggie pizza.";
        }
    }
}