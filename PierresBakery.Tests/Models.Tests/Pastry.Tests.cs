using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models.Pastries;

namespace Pastries.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("croissant", 2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryWithType_String()
    {
      Pastry newPastry = new Pastry("croissant", 2);
      Assert.AreEqual("croissant", newPastry.Type);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryWithPrice_Int()
    {
      Pastry newPastry = new Pastry("croissant", 2);
      Assert.AreEqual(2, newPastry.Price);
    }
  }
}