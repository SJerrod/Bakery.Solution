using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;

namespace BakedGoods.Tests
{
  [TestClass]
  public class BreadTests
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
      string breadCountString = "1";
      float breadCount = int.Parse(breadCountString);
      Bread newOrder = new Bread(breadCount, 0);
      float breadPrice = newOrder.GetBreadPrice();
      Assert.AreEqual(5, newOrder.GetBreadPrice());
    }

    [TestMethod]
    public void BreadPriceWithDeal_CalculatesBreadCostWithDeal_Float()
    {
      string breadCountString = "3";
      float breadCount = int.Parse(breadCountString);
      Bread newOrder = new Bread(breadCount, 0);
      float breadPrice = newOrder.GetBreadPrice();
      Assert.AreEqual(10, newOrder.GetBreadPrice());
    }
  }
}