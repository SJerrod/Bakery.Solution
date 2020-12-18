using System;

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
}