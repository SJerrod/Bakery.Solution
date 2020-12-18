using System;

namespace BakedGoods.Models
{
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
      return _pastryPrice;
    }
  }
}