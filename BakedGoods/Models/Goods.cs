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
      return _breadPrice;
    }
  }
}