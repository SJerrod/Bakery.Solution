using System;
using BakedGoods.Models;

class Bakery
{
  static void Main()
  {
    // Greet
    Console.WriteLine("Welcome to 'Bready or Knot'");
    Console.WriteLine("Thanks for choosing your baked goods through us.");
    Console.WriteLine(":----------------------------------------------:");
    // Order
    Console.WriteLine("To place an order for Bread please enter 1");
    Console.WriteLine("To place an order for Pastries please enter 2");
    string newOrder = Console.ReadLine();
    if(newOrder == "1")
    {
      Console.WriteLine("How many loafs would you like to add to the order?");
      string breadCountString = Console.ReadLine();
      float breadCount = int.Parse(breadCountString);
      Bread breadOrder = new Bread(breadCount,0);
      float breadPrice = breadOrder.GetBreadPrice();
      string breadTotal = new String("$" + breadOrder.GetBreadPrice() + ".00");
      Console.WriteLine(breadOrder.GetBreadCount() + " loafs comes to " + breadTotal);
    }
    else if(newOrder == "2")
    {
      Console.WriteLine("How many Pastries would you like to add to the order?");
      string pastryCountString = Console.ReadLine();
      float pastryCount = int.Parse(pastryCountString);
      Pastry pastryOrder = new Pastry(pastryCount,0);
      float pastryPrice = pastryOrder.GetPastryPrice();
      string pastryTotal = new String("$" + pastryOrder.GetPastryPrice() + ".00");
      Console.WriteLine(pastryOrder.GetPastryCount() + " pastries comes to " + pastryTotal);
    }
    else
    {
      Console.WriteLine("We Currently dont have a product type for that Input.");
      Console.WriteLine(":---------------------------------------------------:");
      Main();
    }
  }
}