using FactoryExample;
using Xunit;

namespace FactoryExampleTests
{
    public class PepperoniPizzaTests
    {
        private const string PepperoniPizzaAddCheeseString = "Adding cheese to the pepperoni pizza.";
        private const string PepperoniPizzaAddSauceString = "Adding sauce to the pepperoni pizza.";
        private const string PepperoniPizzaAddToppingsString = "Adding pepperonis to the pizza.";
        private const string PepperoniPizzaBakePizzaString = "Baking pizza.";

        private PizzaBase pepperoniPizza;

        /// <summary>
        /// Creats the pizza object that will be used for all the tests.
        /// </summary>
        public PepperoniPizzaTests()
        {
            pepperoniPizza = new PepperoniPizza();
        }

        [Fact]
        public void AddCheeseTest()
        {
            Assert.True(Utility.AreEqual(pepperoniPizza.AddCheese(), PepperoniPizzaAddCheeseString));
        }

        [Fact]
        public void AddSauceTest()
        {
            Assert.True(Utility.AreEqual(pepperoniPizza.AddSauce(), PepperoniPizzaAddSauceString));
        }

        [Fact]
        public void AddToppingsTest()
        {
            Assert.True(Utility.AreEqual(pepperoniPizza.AddToppings(), PepperoniPizzaAddToppingsString));
        }

        [Fact]
        public void BakePizzaTest()
        {
            Assert.True(Utility.AreEqual(pepperoniPizza.BakePizza(), PepperoniPizzaBakePizzaString));
        }
    }
}