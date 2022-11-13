namespace AcmeVendingMachines
{
  public class Coin
  {
    public Coin(int denomition)
    {
      Denomination = denomition;
    }

    public int Denomination { get; set; }
  }
}
