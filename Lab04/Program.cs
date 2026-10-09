/*
* Name: Z Bradford
* Course: CSCI 1250, Section 201
* Assignment: Lab 04, Trip Calculator
* Date: September 27, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

//Part One: The Trip
using System.Runtime.CompilerServices;

Console.WriteLine("=== Part 1: The Trip ===");

//Questions
Console.Write("How many pizzas: ");
double numberPizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

//Calculations
double fuel = FuelCost(260, 28, 2.89);
double pizzaCost = numberPizzas * pizzaPrice;
double tripTotal = fuel + pizzaCost;

//Print The Calculations
Console.WriteLine(" ");
Console.WriteLine("Fuel cost: " + fuel.ToString("C"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine(" ");

//Part Two: The Group
Console.WriteLine("=== Part 2: The Group ===");

//Questions

//Constant
const int pizzaSlices = 8;

//Arrays
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

//Calculations
double totalSlices = numberPizzas * pizzaSlices;
double personSlices = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;
//Print The Calculations
Console.WriteLine("People going: " + names.Length);
Console.WriteLine("Slices each: " + personSlices.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine(" ");

//Part Three: Who Works How Long
Console.WriteLine("=== Part 3: Who Works How Long ===");

//For Loop
for (int i = 0; i < names.Length; i++)
{
    double takeHomePerHour = TakeHomePay( hoursWorked[i], hourlyRates[i], 0.18) / hoursWorked[i]
   ;double rateMinusTax = TakeHomePay(hoursWorked[i], hourlyRates[i], 0.18) / hoursWorked[i]
    ;Console.WriteLine(names[i] + ": takes home " + TakeHomePay( hoursWorked[i], hourlyRates[i], 0.18).ToString("C") + " for " + hoursWorked[i] + " hours, " + rateMinusTax.ToString("C") + " per hour, must work " + HoursToCover(costPerPerson, takeHomePerHour).ToString("F2") + " hours");
}

// Calculations
double takeHomePayPerHour = TakeHomePay( hoursWorked[2], hourlyRates[2], 0.18) / hoursWorked[2];
double totalHours = hoursWorked[0] + hoursWorked[1] + hoursWorked[2] + hoursWorked[3];
double totalPay = TakeHomePay(hoursWorked[0], hourlyRates[0], 0.18) + TakeHomePay(hoursWorked[1], hourlyRates[1], 0.18) + TakeHomePay(hoursWorked[2], hourlyRates[2], 0.18)+ TakeHomePay(hoursWorked[3], hourlyRates[3], 0.18);

//Print Total Stats
Console.WriteLine(" ");
Console.WriteLine("Total hours worked: " + totalHours);
Console.WriteLine("Total take home pay: " + totalPay.ToString("C"));
Console.WriteLine("Longest anyone must work: " + HoursToCover(costPerPerson, takeHomePayPerHour).ToString("F2"));

//Methods
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
static double TakeHomePay(double hoursWorked, double hourlyRates, double taxRate)
{
    double grossPay = hoursWorked * hourlyRates;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
    
}
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}
