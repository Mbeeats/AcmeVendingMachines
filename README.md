# AcmeVendingMachines
Acme Vending Machines Assessment 
1. Instructions
a. Spend up to 1 hour attempting to write a solution to the problem below in C#. You don’t need to
complete the solution just give it a good effort.
i. If at any stage you have questions please reach out to me and I will do my best to
answer them.
ii. If you know how to write test please write test for your solution, if not don’t worry.
b. Once you are ready to submit please commit your solution to a git repository like git hub and
send me the link so I may review it.
c. If I am happy with what I see I will reach out to setup a 1-hour pairing session in which we will
complete and/or extend the solution.
d. Please make every effort to complete this assessment with-in 1 week of receiving it.
2. The Problem
You need to write some software to calculate the minimum number of coins required to return change to
a user of Acme Vending machines.
For example, the vending machine uses the following coins denominations: 1,2,5 and 10 cents.
If a user requires change of 43 cents what is the minimum number of coins required?
It would be 4 – 10 cents, 1 – 2 cents and 1 – 1 cent.
The coin denominations must be supplied as a parameter. This is so the algorithm is not specific to one
country’s currency since Acme supplies vending machines to various countries around the world.
Please use the following country’s coin denominations to solve the problem:
• British Pound
o 1,2,5,10,20,50
• US Dollar
o 1,5,10,25

The problem assumes an infinite number of coins of each denomination.
You are to return an array populated with each coin’s denomination to be given as change.
Example
var coinDenominations = [1,5,10,25]; // coin denominations – US Dollar
var machine = new VendingMachine(coinDenominations);
var purchaseAmount = 1.35; // amount the item cost
var tenderAmount = 2.00; // amount the user input for the purchase
var change = machine.CalculateChange(purchaseAmount, tenderAmount); // expect 65 cents
// The expected result would be an array that looks like
// change[0] = 25
// change[1] = 25
// change[2] = 10
// change[3] = 5
