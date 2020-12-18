using System;

namespace BakedGoods.Models
{
  public class Program
  {
    static void Main()
    {
      void Greet()
      {
      Console.WriteLine("Welcome to 'Bready or Knot'");
      Console.WriteLine("Thanks for choosing your baked goods through us.");
      Console.WriteLine(":----------------------------------------------:");
      }
      Greet();
      float breadTotalCost = 0;
      float pastryTotalCost = 0;
      float breadAmount = 0;
      float pastryAmount = 0;
      void Order()
      {
        Console.WriteLine("Enter 1 to add bread to order *Buy 2 Get 1 Free ($5.00 per loaf)*");
        Console.WriteLine("Enter 2 to add pastry to order *1 for $2.00 or 3 for $5.00*");
        Console.WriteLine("Enter 3 to display order total.");
        string newOrder = Console.ReadLine();
        if(newOrder == "1")
        {
          Console.WriteLine("How many loafs would you like to add to the order?");
          Console.WriteLine("Todays Deal: Buy 2 loafs get your 3rd Free");
          string breadCountString = Console.ReadLine();
          float breadCount = int.Parse(breadCountString);
          Bread breadOrder = new Bread(breadCount,0);
          float breadPrice = breadOrder.GetBreadPrice();
          string orderTotal = new String("$" + breadPrice + ".00");
          breadTotalCost += breadPrice;
          breadAmount += breadCount;
          Console.WriteLine(breadOrder.BreadCount + " loafs comes to " + orderTotal);
          Order();
        }
        else if(newOrder == "2")
        {
          Console.WriteLine("How many Pastries would you like to add to the order?");
          Console.WriteLine("Todays Deal: 3 for $5.00 ");
          string pastryCountString = Console.ReadLine();
          float pastryCount = int.Parse(pastryCountString);
          Pastry pastryOrder = new Pastry(pastryCount,0);
          float pastryPrice = pastryOrder.GetPastryPrice();
          string orderTotal = new String("$" + pastryPrice + ".00");
          pastryTotalCost += pastryPrice;
          pastryAmount += pastryCount;
          Console.WriteLine(pastryOrder.PastryCount + " pastries comes to " + orderTotal);
          Order();
        }
        else if (newOrder == "3")
        {
          float breadSaving = 0;
          float pastrySaving = 0;
          float concatTotal = breadTotalCost + pastryTotalCost;
          string orderTotal = new String("$" + concatTotal + ".00");
          Console.WriteLine("You have ordered " + breadAmount + " loafs of bread.");
          while (breadAmount >=3)
          {
            breadAmount -= 3;
            breadSaving += 5;
          }
          Console.WriteLine("You Saved $" + breadSaving + ".00 off your bread order today.");
          Console.WriteLine("You have ordered " + pastryAmount + " pastries.");
          while (pastryAmount >=3)
          {
            pastryAmount -= 3;
            pastrySaving += 1;
          }
          Console.WriteLine("You Saved $" + pastrySaving + ".00 off your pastry order today.");
          Console.WriteLine("Todays total comes to " + orderTotal);
        }
        else
        {
          Console.WriteLine(":---------------------------------------------------------:");
          Console.WriteLine("Sorry we currently dont have a product type for that Input.");
          Console.WriteLine(":---------------------------------------------------------:");
          Main();
        }
      }
      Order();
    }
  }
}