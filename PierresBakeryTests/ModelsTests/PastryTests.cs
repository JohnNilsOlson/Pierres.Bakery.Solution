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
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryWithType_String()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(string), (newPastry.Type).GetType());
    }

    [TestMethod]
    public void PastryConstructor_RemovesEntryFromTypeDictionary_True()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(9, newPastry.pastryTypes.Count);
    }
  }
}