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
    public bool RemoveQuarter(double TotalChange)
    {
      if (TotalChange > .25)
      {
        TotalChange -= .25;
        return true;
      } else {
        return false;
      }
    }
    public bool RemoveDime(double TotalChange)
    {
      if (TotalChange > .1)
      {
        TotalChange -= .1;
        return true;
      } else {
        return false;
      }
    }
    public bool RemoveNickel(double TotalChange)
    {
      if (TotalChange > .05)
      {
        TotalChange -= .05;
        return true;
      } else {
        return false;
      }
    }
    public bool RemovePenny(double TotalChange)
    {
      if (TotalChange > .01)
      {
        TotalChange -= .01;
        return true;
      } else {
        return false;
      }
    }

    public bool GetChange(double TotalChange)
    {
      while(TotalChange > 0)
      {
        if (TotalChange > .25)
        {
          TotalChange-=.25;
          continue;
        } else if (TotalChange > .1) {
          TotalChange-=.1;
          continue;
        } else if (TotalChange > .05) {
          TotalChange-=.05;
          continue;
        } else {
          TotalChange-=.01;
        }
      }
      return true;
    }

  // End of Class
 }
}
