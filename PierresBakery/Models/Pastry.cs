using System;
using System.Collections.Generic;

namespace PierresBakery.Models.Pastries
{
  public class Pastry
  {
    private Dictionary<int, string> pastryTypes = new Dictionary<int, string>() {{1, "croissant"}, {2, "baklava"}, {3, "struedel"}, {4, "canolli"}, {5, "macaron"}, {6, "bear claw"}, {7, "eclair"}, {8, "cinnamon roll"}, {9, "cream horn"}, {10, "empanada"}};
    public string Type { get; set; }
    public int Price { get; set; }
    public Pastry()
    {
      Random rnd = new Random();
      int num  = rnd.Next(1, 10);

      Type = pastryTypes[num];
      Price = 2;

      pastryTypes.Remove(num);
    }
  }
}