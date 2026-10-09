/*
* Name: Z Bradford
* Course: CSCI 1250, Section 201
* Assignment: Lab 04, Trip Calculator
* Date: September 27, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

//Part One: The Trip
Console.WriteLine("=== Part 1: The Trip ===");

//Questions
Console.Write("How many pizzas: ");
double numberPizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

/*Constant
const int pizzaSlices = 8;
*/

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
/*
//Part Two: The Group
Console.WriteLine("=== Part 2: The Group ===");

//Questions

//Constant
const int pizzaSlices = 8;

//Calculations
double totalSlices = numberPizzas * pizzaSlices;
double personSlices = totalSlices / ;
//Print The Calculations
Console.WriteLine(" ");

Console.WriteLine("Total slices: " + totalSlices.ToString("F0"));
Console.WriteLine("Slices per person: " + personSlices.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine(" ");

//Part Three: Who Works How Long
Console.WriteLine("=== Part 3: Who Works How Long ===");
//Questions


//Calculations
double takeHomePay = TakeHomePay( , , 0.18);
double hoursNeeded = HoursToCover();

//Print The Calculations
Console.WriteLine(" ");

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
Console.WriteLine(" ");
*/
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * hourlyRate;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
    
}
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}
