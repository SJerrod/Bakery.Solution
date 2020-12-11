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

      while(loafs > 0)
      {
        if(loafs >= 3)
        {
          loafs -= 3;
          _breadPrice += 10;
        }
        else if (loafs == 2)
        {
          loafs -= 2;
          _breadPrice += 10;
        }
        else if (loafs == 1)
        {
          loafs -= 1;
          _breadPrice += 5;
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
  }
}