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
      Bread newBread = new Bread("rye", 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithType_String()
    {
      Bread newBread = new Bread("rye", 5);
      Assert.AreEqual("rye", newBread.Type);
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithPrice_Int()
    {
      Bread newBread = new Bread("rye", 5);
      Assert.AreEqual(5, newBread.Price);
    }
  }
}
