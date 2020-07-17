using System;
using PierresBakery.Models.Menus;
using PierresBakery.Models.Breads;
using PierresBakery.Models.Pastries;

namespace PierresBakery
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("------------------------------------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Offering a fine selection of breads and pastries since 2020.");
      Console.WriteLine("------------------------------------------------------------");
      Menu todaysMenu = new Menu();
      todaysMenu.BuildMenu();
      Console.WriteLine("What would you like today?");
      Console.WriteLine("Enter 'bread' to view today's bread menu.");
      Console.WriteLine("Enter 'pastry' to view today's pastry menu.");
      string choice = (Console.ReadLine().ToLower());
      if (choice == "bread")
      {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Today's Breads");
        Console.WriteLine("------------------------------------------------------------");
        foreach (Bread obj in todaysMenu.Breads)
        {
          Console.WriteLine((todaysMenu.Breads.IndexOf(obj) + 1) + ". " + obj.Type);
        }
        Console.WriteLine("What would you like today?");
        Console.WriteLine("Enter the number of the item to add to your order.");
        string stringChoice = Console.ReadLine();
        int intChoice = int.Parse(stringChoice);
        Console.WriteLine("How many would you like?");
        string stringLoaves = Console.ReadLine();
        int intLoaves = int.Parse(stringLoaves);
        int i = 0;
        while (i < intLoaves)
        {
          todaysMenu.AddBreadToOrder(intChoice - 1);
          i++;
        }
      }
      else if (choice == "pastry")
      {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Today's Pastries");
        Console.WriteLine("------------------------------------------------------------");
        foreach (Pastry obj in todaysMenu.Pastries)
        {
          Console.WriteLine((todaysMenu.Pastries.IndexOf(obj) + 1) + ". " + obj.Type);
        }
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("What would you like today?");
        Console.WriteLine("Enter the number of the item to add to your order.");
        string stringChoice = Console.ReadLine();
        int intChoice = int.Parse(stringChoice);
        Console.WriteLine("How many would you like?");
        string stringPastries = Console.ReadLine();
        int intPastries = int.Parse(stringPastries);
        int i = 0;
        while (i < intPastries)
        {
          todaysMenu.AddPastryToOrder(intChoice - 1);
          i++;
        }
      }
      Console.WriteLine("Your order will be:");
      todaysMenu.CalculateOrderTotal();
      todaysMenu.ApplyDiscount();
      Console.WriteLine("$" + todaysMenu.OrderTotal + ".00");
      Console.WriteLine("Thank you, come again!");
    }
  }
}