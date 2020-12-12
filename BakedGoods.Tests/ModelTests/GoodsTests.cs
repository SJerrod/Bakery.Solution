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
      string breadCountString = "6";
      float breadCount = int.Parse(breadCountString);
      Bread newOrder = new Bread(breadCount, 20);
      Assert.AreEqual(6, newOrder.BreadCount);
    }

    [TestMethod]
    public void BreadPrice_CalculatesBreadCost_Float()
    {
      string breadCountString = "7";
      float breadCount = int.Parse(breadCountString);
      Bread newOrder = new Bread(breadCount, 0);
      float breadPrice = newOrder.GetBreadPrice();
      Assert.AreEqual(25, newOrder.GetBreadPrice());
    }

    [TestMethod]
    public void PastryConstructor_CreatesPastry_Pastry()
    {
      Pastry newOrder = new Pastry(6,10);
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }

    [TestMethod]
    public void PastryCount_AddsAmountOfPastryToCount_Float()
    {
      string pastryCountString = "6";
      float pastryCount = int.Parse(pastryCountString);
      Pastry newOrder = new Pastry(pastryCount,0);
      Assert.AreEqual(6, newOrder.PastryCount);
    }

    [TestMethod]
    public void PastryPrice_CalculatesPastryCost_Float()
    {
      string pastryCountString = "7";
      float pastryCount = int.Parse(pastryCountString);
      Pastry newOrder = new Pastry(pastryCount, 0);
      float pastryPrice = newOrder.GetPastryPrice();
      Assert.AreEqual(12, newOrder.GetPastryPrice());
    }
  }
}