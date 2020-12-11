using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;

namespace BakedGoods.TestTools
{
  [TestClass]

  public class GoodsTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesBreadOrder_Bread()
    {
      Bread newOrder = new Bread(3, 10);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

    [TestMethod]
    public void BreadCount_AddsAmountToBreadCount_Float()
    {
      string breadString = "7";
      float breadCount = int.Parse(breadString);
      Bread newOrder = new Bread(breadCount, 20);
      Assert.AreEqual(6, newOrder.GetBreadCount());
    }
  }
}