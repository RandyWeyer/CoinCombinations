using System;

namespace CoinCombinations
{
  public class CoinCombinations
  {
    public bool CannotRemoveQuarter(double TotalChange)
    {
      if (TotalChange < .25)
      {
        return true;
      } else {
        return false;
      }
    }



  // End of Class
 }
}
