using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models.Breads;

namespace Breads.Tests
{
  [TestClass]
  public class BreadsTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void SetPrice_AppliesPriceValueToBread_Int()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.Price);
    }
  }
}
