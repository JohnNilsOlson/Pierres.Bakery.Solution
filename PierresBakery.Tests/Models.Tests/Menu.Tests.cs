using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models.Menus;
using PierresBakery.Models.Breads;

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
      Assert.AreEqual(1, (todaysMenu.Breads).Count);
    }

    [TestMethod]
    public void BuildMenu_AddsPastryToList_List()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      Assert.AreEqual(1, (todaysMenu.Pastries).Count);
    }
  }
}