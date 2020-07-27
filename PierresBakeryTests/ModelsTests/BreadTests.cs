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
    public void BreadConstructor_CreatesInstanceOfBreadWithType_String()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(string), (newBread.Type).GetType());
    }

    [TestMethod]
    public void BreadConstructor_RemovesEntryFromTypeDictionary_True()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(9, newBread.breadTypes.Count);
    }
  }
}
