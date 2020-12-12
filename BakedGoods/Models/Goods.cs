using System;
using BakedGoods;

namespace BakedGoods.Models
{
  public class Bread
  {
    public float BreadCount { get; set;}
    private float _breadPrice;

    public Bread(float breadCount, float breadPrice)
    {
      BreadCount = breadCount;
      _breadPrice = breadPrice;
    }

    public float GetBreadPrice()
    {
      float loafs = BreadCount;
      _breadPrice = 0;

      if(loafs == 0)
      {
        // Loops Twice cant break or return tried switch case and re-working while loop
        Console.WriteLine("You currently have no bread for your order.");
      }
      else
      {
        while(loafs > 0)
        {
          if(loafs >= 3)
          {
            loafs -= 3;
            _breadPrice += 10;
          }
          else if (loafs < 3)
          {
            loafs -= 1;
            _breadPrice += 5;
          }
        }
      }
      return _breadPrice;
    }
  }

  public class Pastry
  {
    public float PastryCount { get; set; }
    private float _pastryPrice;

    public Pastry(float pastryCount, float pastryPrice)
    {
      PastryCount = pastryCount;
      _pastryPrice = pastryPrice;
    }

    public float GetPastryPrice()
    {
      float treats = PastryCount;
      _pastryPrice = 0;

      if (treats == 0)
      {
        Console.WriteLine("You Currently have no Pastries for your order.");
      }
      else
      {
        while(treats > 0)
        {
          if (treats >= 3)
          {
            treats -= 3;
            _pastryPrice += 5;
          }
          else if (treats < 3)
          {
            treats -= 1;
            _pastryPrice += 2;
          }
        }
      }
      return _pastryPrice;
    }
  }

  // public class Order
  // {
  //   void NewOrder()
  //   {
  //     Console.WriteLine("To place an order for Bread please enter 1");
  //     Console.WriteLine("To place an order for Pastries please enter 2");
  //     string newOrder = Console.ReadLine();
  //     if(newOrder == "1")
  //     {
  //       Console.WriteLine("How many loafs would you like to add to the order?");
  //       string breadCountString = Console.ReadLine();
  //       float breadCount = int.Parse(breadCountString);
  //       Bread breadOrder = new Bread(breadCount,0);
  //       float breadPrice = breadOrder.GetBreadPrice();
  //       string breadTotal = new String("$" + breadOrder.GetBreadPrice() + ".00");
  //       Console.WriteLine(breadOrder.GetBreadCount() + " loafs comes to " + breadTotal);
  //     }
  //     else if(newOrder == "2")
  //     {
  //       Console.WriteLine("How many Pastries would you like to add to the order?");
  //       string pastryCountString = Console.ReadLine();
  //       float pastryCount = int.Parse(pastryCountString);
  //       Pastry pastryOrder = new Pastry(pastryCount,0);
  //       float pastryPrice = pastryOrder.GetPastryPrice();
  //       string pastryTotal = new String("$" + pastryOrder.GetPastryPrice() + ".00");
  //       Console.WriteLine(pastryOrder.GetPastryCount() + " pastries comes to " + pastryTotal);
  //     }
  //     else
  //     {
  //       Console.WriteLine(":---------------------------------------------------------:");
  //       Console.WriteLine("Sorry we currently dont have a product type for that Input.");
  //       Console.WriteLine(":---------------------------------------------------------:");
  //       NewOrder();
  //     }
  //   }
  // }
}