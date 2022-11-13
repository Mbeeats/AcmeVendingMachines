using AcmeVendingMachines.Models;
using System;

namespace AcmeVendingMachines
{
  class Program
  {
    static void Main(string[] args)
    {
      //As Example
      int[] usDollarDenominations = { 1, 5, 10, 25 };// coin denominations – US Dollar
      var machine = new VendingMachine(usDollarDenominations);
      machine.Curreny = "US Dollars";
      Console.WriteLine($"{ machine.Curreny} Test");
      var purchaseAmount = 1.35; // amount the item cost
      var tenderAmount = 2.00; // amount the user input for the purchase
      var change = machine.CalculateChange(purchaseAmount, tenderAmount);
      Console.WriteLine($"expect : {machine.Cents} cents");
      for (int i = 0; i < change.Count; i++)
      {
        Console.WriteLine($"change[{i}]: = {change[i].Denomination}");
      }
      //expect: 65 cents
      //change[0]: = 25
      //change[1]: = 25
      //change[2]: = 10
      //change[3]: = 5
      Console.WriteLine();

      int [] britishPoundDenominations = { 1, 2, 5, 10, 20, 50 };// coin denominations – British Pounds
      machine = new VendingMachine(britishPoundDenominations);
      machine.Curreny = "British Pounds";
      Console.WriteLine($"{ machine.Curreny} Test");
      purchaseAmount = 1.62; // amount the item cost
      tenderAmount = 2.00; // amount the user input for the purchase
      change = machine.CalculateChange(purchaseAmount, tenderAmount);
      Console.WriteLine($"expect : {machine.Cents} cents");
      for (int i = 0; i < change.Count; i++)
      {
        Console.WriteLine($"change[{i}]: = {change[i].Denomination}");
      }
      //expect: 38 cents
      //change[0]: = 20
      //change[1]: = 10
      //change[2]: = 5
      //change[3]: = 2
      //change[4]: = 1
      Console.WriteLine();

      //Personal Test
      //US Dollar
      machine = new VendingMachine(usDollarDenominations);
      machine.Curreny = "US Dollars";
      Console.WriteLine($"{ machine.Curreny} Test");
      purchaseAmount = 2.00; // amount the item cost
      tenderAmount = 6.25; // amount the user input for the purchase
      change = machine.CalculateChange(purchaseAmount, tenderAmount);
      Console.WriteLine($"expect : {machine.Cents} cents");
      for (int i = 0; i < change.Count; i++)
      {
        Console.WriteLine($"change[{i}]: = {change[i].Denomination}");
      }
      //US Dollars Test
      //expect: 425 cents
      //change[0]: = 25
      //change[1]: = 25
      //change[2]: = 25
      //change[3]: = 25
      //change[4]: = 25
      //change[5]: = 25
      //change[6]: = 25
      //change[7]: = 25
      //change[8]: = 25
      //change[9]: = 25
      //change[10]: = 25
      //change[11]: = 25
      //change[12]: = 25
      //change[13]: = 25
      //change[14]: = 25
      //change[15]: = 25
      //change[16]: = 25
      Console.WriteLine();

      //British Pounds
      machine = new VendingMachine(britishPoundDenominations);
      machine.Curreny = "British Pounds";
      Console.WriteLine($"{ machine.Curreny} Test");
      purchaseAmount = 2.00; // amount the item cost
      tenderAmount = 10.35; // amount the user input for the purchase
      change = machine.CalculateChange(purchaseAmount, tenderAmount);
      Console.WriteLine($"expect : {machine.Cents} cents");
      for (int i = 0; i < change.Count; i++)
      {
        Console.WriteLine($"change[{i}]: = {change[i].Denomination}");
      }
      //British Pounds Test
      //expect: 835 cents
      //change[0]: = 50
      //change[1]: = 50
      //change[2]: = 50
      //change[3]: = 50
      //change[4]: = 50
      //change[5]: = 50
      //change[6]: = 50
      //change[7]: = 50
      //change[8]: = 50
      //change[9]: = 50
      //change[10]: = 50
      //change[11]: = 50
      //change[12]: = 50
      //change[13]: = 50
      //change[14]: = 50
      //change[15]: = 50
      //change[16]: = 20
      //change[17]: = 10
      //change[18]: = 5
      Console.WriteLine();
      Console.ReadLine();
    }
  }
}
