using FactoryExample;
using Xunit;

namespace FactoryExampleTests
{
    public class PepperoniPizzaTests
    {
        private const string PepperoniPizzaAddCheeseString = "Adding cheese to the pepperoni pizza.";
        private const string PepperoniPizzaAddSauceString = "Adding sauce to the pepperoni pizza.";
        private const string PepperoniPizzaBakePizzaString = "Baking pizza.";

        private PizzaBase pepperoniPizza;

        public PepperoniPizzaTests()
        {
            pepperoniPizza = new PepperoniPizza();
        }

        [Fact]
        public void AddCheeseTest()
        {
            Assert.True(AreEqual(pepperoniPizza.AddCheese(), PepperoniPizzaAddCheeseString));
        }

        [Fact]
        public void AddSauceTest()
        {
            Assert.True(AreEqual(pepperoniPizza.AddSauce(), PepperoniPizzaAddSauceString));
        }

        [Fact]
        public void BakePizzaTest()
        {
            Assert.True(AreEqual(pepperoniPizza.BakePizza(), PepperoniPizzaBakePizzaString));
        }

        private bool AreEqual(string inputString, string constantString)
        {
            return inputString == constantString;
        }
    }
}