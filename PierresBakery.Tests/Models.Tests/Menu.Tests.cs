using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models.Menus;

namespace Menus.Tests
{
  [TestClass]
  public class MenuTests
  {
    [TestMethod]
    public void MenuConstructor_CreatesInstanceOfMenu_Menu()
    {
      Menu todaysMenu = new Menu();
      Assert.AreEqual(typeof(Menu), todaysMenu.GetType());
    }

    [TestMethod]
    public void BuildMenu_AddsBreadsToList_List()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      Assert.IsTrue(0 < (todaysMenu.Breads).Count);
    }

    [TestMethod]
    public void BuildMenu_AddsPastryToList_List()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      Assert.IsTrue(0 < (todaysMenu.Pastries).Count);
    }
  }
}