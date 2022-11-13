using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AcmeVendingMachines.Models
{
  
  public class VendingMachine : IVendingMachine 
  {
    private List<Coin> CoinDenominations { get; set; }
    public int Cents { get; set; }
    public int WholePart { get; set; }
    public string Curreny { get; set; }

    public VendingMachine(int[] coinDenominations)
    {
      CoinDenominations = new List<Coin>();
      foreach (var coin in coinDenominations)
      {
        CoinDenominations.Add(new Coin(coin));
      }
      CoinDenominations.Sort(delegate (Coin x, Coin y) { return x.Denomination.CompareTo(y.Denomination); });
      CoinDenominations.Reverse();
    }

    public List<Coin> CalculateChange(double purchaseAmount, double tenderAmount)
    {
      var change = tenderAmount - purchaseAmount;
      string s = change.ToString("0.00", CultureInfo.InvariantCulture);
      string[] parts = s.Split('.');
      WholePart = int.Parse(parts[0]);
      Cents = int.Parse(parts[1]);
      var coins =  GetCoins();
      return coins;
    }

    public List<Coin> GetCoins()
    {
      if (WholePart > 0)
      {
        Cents += WholePart * 100;
      }
      var change = Cents;
      var coins = new List<Coin>();
      foreach (var coin in CoinDenominations)
      {
        var count = change / coin.Denomination;
        if (count != 0)
        {
          Math.DivRem((int)change, coin.Denomination, out int item);
          coins.AddRange(Enumerable.Repeat(coin, count));
          change = item;
        }

      }
      return coins;
    }
  }
}
