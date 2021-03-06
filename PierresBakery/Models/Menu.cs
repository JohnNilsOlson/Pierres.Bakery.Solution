using System;
using System.Collections.Generic;
using PierresBakery.Models.Breads;
using PierresBakery.Models.Pastries;

namespace PierresBakery.Models.Menus
{
  public class Menu
  {
    public List<Bread> Breads { get; set; }
    public List<Pastry> Pastries {get; set; }
    public List<Object> Order { get; set; }
    public int OrderTotal { get; set; }
    public Menu()
    {
      Breads = new List<Bread>();
      Pastries = new List<Pastry>();
      Order = new List<Object>();
      OrderTotal = 0;
    }
    public void BuildMenu()
    {
      Random rnd = new Random();
      int numBread  = rnd.Next(1, 10);
      int numPastry = rnd.Next(1,10);

      int i = 0;
      while (i < numBread)
      {
        Bread newBread = new Bread();
        if (newBread.Type != null)
        {
          Breads.Add(newBread);
        }
        i++;
      }

      int j = 0;
      while (j < numPastry)
      {
        Pastry newPastry = new Pastry();
        if (newPastry.Type != null)
        {
          Pastries.Add(newPastry);
        }
        j++;
      }
    }
    public void AddPastryToOrder(int input)
    {
      Order.Add(Pastries[input]);
    }
    public void AddBreadToOrder(int input)
    {
      Order.Add(Breads[input]);
    }
    public void CalculateOrderTotal()
    {
      foreach (Object obj in Order)
      {
        if (obj.GetType() == typeof(Bread))
        {
          OrderTotal += 5;
        }
        else
        {
          OrderTotal += 2;
        }
      }
    }
    public void ApplyDiscount()
    {
      int breadCount = 0;
      int pastryCount = 0;
      foreach (Object obj in Order)
      {
        if (obj.GetType() == typeof(Bread))
        {
          breadCount += 1;
        }
        else
        {
          pastryCount += 1;
        }
      }
      int breadDiscount = (breadCount - (breadCount % 3));
      OrderTotal -= (5 * (breadDiscount / 3));
      int pastryDiscount = (pastryCount - (pastryCount % 3));
      OrderTotal -= (1 * (pastryDiscount / 3));
    }
  }
}