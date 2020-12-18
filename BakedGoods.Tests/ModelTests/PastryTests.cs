using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;

namespace BakedGoods.Tests
{
  [TestClass]
  public class PastryTests
  {
    
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
      string pastryCountString = "2";
      float pastryCount = int.Parse(pastryCountString);
      Pastry newOrder = new Pastry(pastryCount, 0);
      float pastryPrice = newOrder.GetPastryPrice();
      Assert.AreEqual(4, newOrder.GetPastryPrice());
    }

    [TestMethod]
    public void PastryPriceWithDeal_CalculatesPastryCostWithTheDeal_Float()
    {
      string pastryCountString = "6";
      float pastryCount = int.Parse(pastryCountString);
      Pastry newOrder = new Pastry(pastryCount, 0);
      float pastryPrice = newOrder.GetPastryPrice();
      Assert.AreEqual(10, newOrder.GetPastryPrice());
    }
  }
}