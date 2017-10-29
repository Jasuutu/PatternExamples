using FactoryExample;
using Xunit;

namespace FactoryExampleTests
{
    public class VeggiePizzaTests
    {
        private const string VeggiePizzaAddCheeseString = "Adding cheese to the veggie pizza.";
        private const string VeggiePizzaAddSauceString = "Adding the sauce to the veggie pizza.";
        private const string VeggiePizzaAddToppingsString = "Adding veggies to the pizza.";
        private const string VeggiePizzaBakePizzaString = "Baking the veggie pizza.";

        private readonly PizzaBase vegiePizza;

        public VeggiePizzaTests()
        {
            vegiePizza = new VeggiePizza();
        }

        [Fact]
        public void AddCheeseTest()
        {
            Assert.True(Utility.AreEqual(vegiePizza.AddCheese(), VeggiePizzaAddCheeseString));
        }

        [Fact]
        public void AddSauceTest()
        {
            Assert.True(Utility.AreEqual(vegiePizza.AddSauce(), VeggiePizzaAddSauceString));
        }

        [Fact]
        public void AddToppingsTest()
        {
            Assert.True(Utility.AreEqual(vegiePizza.AddToppings(), VeggiePizzaAddToppingsString));
        }

        [Fact]
        public void BakePizzaTest()
        {
            Assert.True(Utility.AreEqual(vegiePizza.BakePizza(), VeggiePizzaBakePizzaString));
        }
    }
}