using FactoryExample;
using Xunit;

namespace FactoryExampleTests
{
    public class PizzaFactoryTests
    {
        [Fact]
        public void CheesePizzaTest()
        {
            var cheesePizza = PizzaFactory.MakePizza("Cheese");
            Assert.True(cheesePizza.HasCheese);
            Assert.True(cheesePizza.HasSauce);
            Assert.True(cheesePizza.HasToppings);
            Assert.True(cheesePizza.WasBaked);
        }

        [Fact]
        public void PepperoniPizzaTest()
        {
            var pepperoniPizza = PizzaFactory.MakePizza("Pepperoni");
            Assert.True(pepperoniPizza.HasCheese);
            Assert.True(pepperoniPizza.HasSauce);
            Assert.True(pepperoniPizza.HasToppings);
            Assert.True(pepperoniPizza.WasBaked);
        }

        [Fact]
        public void VeggiePizzaTest()
        {
            var veggiePizza = PizzaFactory.MakePizza("Veggie");
            Assert.True(veggiePizza.HasCheese);
            Assert.True(veggiePizza.HasSauce);
            Assert.True(veggiePizza.HasToppings);
            Assert.True(veggiePizza.WasBaked);
        }
    }
}