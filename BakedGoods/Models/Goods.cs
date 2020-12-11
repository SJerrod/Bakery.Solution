using System;

namespace BakedGoods.Models
{
  public class Bread
  {
    private float _breadCount;
    private float _breadPrice;

    public Bread(float breadCount, float breadPrice)
    {
      _breadCount = breadCount;
      _breadPrice = breadPrice;
    }

    public float GetBreadCount()
    {
      return _breadCount;
    }

    public float GetBreadPrice()
    {
      float loafs = _breadCount;
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

  public class Pastry
  {
    private float _pastryCount;
    private float _pastryPrice;

    public Pastry(float pastryCount, float pastryPrice)
    {
      _pastryCount = pastryCount;
      _pastryPrice = pastryPrice;
    }

    public float GetPastryCount()
    {
      return _pastryCount;
    }

    public float GetPastryPrice()
    {
      float treats = _pastryCount;
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
}