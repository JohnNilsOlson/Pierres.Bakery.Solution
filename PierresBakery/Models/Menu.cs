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
      Breads.Add(newBread);
      i++;
      }

      int j = 0;
      while (j < numPastry)
      {
      Pastry newPastry = new Pastry();
      Pastries.Add(newPastry);
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
  }
}