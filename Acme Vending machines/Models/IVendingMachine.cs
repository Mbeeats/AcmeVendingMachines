using System.Collections.Generic;

namespace AcmeVendingMachines.Models
{
  interface IVendingMachine
  {
    public List<Coin> CalculateChange(double purchaseAmount, double tenderAmount);
  }
}
