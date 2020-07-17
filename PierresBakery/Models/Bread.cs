using System;
using System.Collections.Generic;

namespace PierresBakery.Models.Breads
{
  public class Bread
  {
    private Dictionary<int, string> breadTypes = new Dictionary<int, string>() {{1, "rye"}, {2, "sourdough"}, {3, "whole grain"}, {4, "baguette"}, {5, "ciabatta"}, {6, "challah"}, {7, "cornbread"}, {8, "banana"}, {9, "brioche"}, {10, "foccacia"}};
    public string Type { get; set; }
    public int Price { get; set; }
    public Bread()
    {
      Random rnd = new Random();
      int num  = rnd.Next(1, 10);

      Type = breadTypes[num];
      Price = 5;
    }
  }
}