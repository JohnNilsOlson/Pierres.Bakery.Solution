using System.Collections.Generic;
using PierresBakery.Models.Breads;
using PierresBakery.Models.Pastries;

namespace PierresBakery.Models.Menus
{
  public class Menu
  {
    public List<Bread> Breads { get; set; }
    public List<Pastry> Pastries {get; set; }
    public Menu()
    {
      Breads = new List<Bread>();
      Pastries = new List<Pastry>();
    }
  }
}