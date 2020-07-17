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
    public void BuildMenu_AddsBreadsToList_True()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      Assert.IsTrue(0 < (todaysMenu.Breads).Count);
    }

    [TestMethod]
    public void BuildMenu_AddsPastryToList_True()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      Assert.IsTrue(0 < (todaysMenu.Pastries).Count);
    }

    [TestMethod]
    public void AddPastryToOrder_AddsPastryToOrder_True()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      todaysMenu.AddPastryToOrder(0);
      Assert.IsTrue(0 < (todaysMenu.Order).Count);
    }
    [TestMethod]
    public void AddBreadToOrder_AddsBreadToOrder_True()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      todaysMenu.AddBreadToOrder(0);
      Assert.IsTrue(0 < (todaysMenu.Order).Count);
    }

    [TestMethod]
    public void CalculateOrderTotal_CalculatesValueOfOrder_Int()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      todaysMenu.AddBreadToOrder(0);
      todaysMenu.AddPastryToOrder(0);
      todaysMenu.CalculateOrderTotal();
      Assert.AreEqual(7, todaysMenu.OrderTotal);
    }

    [TestMethod]
    public void ApplyDiscount_AppliesDiscountToOrderTotalForBread_Int()
    {
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      todaysMenu.AddBreadToOrder(0);
      todaysMenu.AddBreadToOrder(0);
      todaysMenu.AddBreadToOrder(0);
      todaysMenu.CalculateOrderTotal();
      todaysMenu.ApplyDiscount();
      Assert.AreEqual(10, todaysMenu.OrderTotal);
    }
  }
}