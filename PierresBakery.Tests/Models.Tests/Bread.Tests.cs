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
      Bread newBread = new Bread("rye");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithType_Type()
    {
      Bread newBread = new Bread("rye");
      Assert.AreEqual("rye", newBread.Type);
    }
  }
}
