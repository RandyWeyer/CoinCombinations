using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinCombinationsTest
  {
    [TestMethod]
    public void TotalCannotRemoveQuarter_True()
    {
      double total = 0.03;
      CoinCombinations testCoinCombinations = new CoinCombinations();
      Assert.AreEqual(true, testCoinCombinations.CannotRemoveQuarter(total));
    }
    [TestMethod]
    public void TotalCanRemoveQuarter_True()
    {
      double total = 0.99;
      CoinCombinations testCoinCombinations = new CoinCombinations();
      Assert.AreEqual(true, testCoinCombinations.RemoveQuarter(total));
    }
    [TestMethod]
    public void TotalCanRemoveDime_True()
    {
      double total = 0.99;
      CoinCombinations testCoinCombinations = new CoinCombinations();
      Assert.AreEqual(true, testCoinCombinations.RemoveDime(total));
    }
    [TestMethod]
    public void TotalCanRemoveNickel_True()
    {
      double total = 0.99;
      CoinCombinations testCoinCombinations = new CoinCombinations();
      Assert.AreEqual(true, testCoinCombinations.RemoveNickel(total));
    }
    [TestMethod]
    public void TotalCanRemovePenny_True()
    {
      double total = 0.99;
      CoinCombinations testCoinCombinations = new CoinCombinations();
      Assert.AreEqual(true, testCoinCombinations.RemovePenny(total));
    }

    [TestMethod]
    public void DoesChangeFunctionStopAtZero_True()
    {
      double total = 0.99;
      CoinCombinations testCoinCombinations = new CoinCombinations();
      Assert.AreEqual(true, testCoinCombinations.GetChange(total));
    }


  }
}
