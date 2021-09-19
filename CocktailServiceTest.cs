using api.Connector;
using api.Models.Response;
using api.Services;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace api.Test
{
    [TestClass]
    public class CocktailServiceTest
    {
        [TestMethod]
        public void Test_GetCocktailListByIngredient()
        {
            MockCocktailConnector mockTailConnector = new MockCocktailConnector();
            ICocktailService CocktailService = new CocktailService(mockTailConnector);
            var actual = CocktailService.GetCocktailListByIngredient("Gin");
            var expected = new CocktailList();
            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void Test_GetRandomCocktaill()
        {
            MockCocktailConnector mockTailConnector = new MockCocktailConnector();
            ICocktailService CocktailService = new CocktailService(mockTailConnector);
            var actual = CocktailService.GetRandomCocktaill();
            var expected = new Cocktail();
            Assert.AreEqual(expected, actual);
        }
    }
}
