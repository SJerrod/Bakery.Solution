using System;
using BakedGoods.Models;

class Bakery
{
  static void Main()
  {
    // Greet
    Console.WriteLine("Welcome to 'Bready or Knot'");
    Console.WriteLine("Thanks for choosing your baked goods through us.");
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
      Console.WriteLine("$" + breadOrder.GetBreadPrice() + ".00");
    }
  }
}