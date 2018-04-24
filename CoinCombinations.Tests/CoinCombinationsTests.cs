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


  }
}
