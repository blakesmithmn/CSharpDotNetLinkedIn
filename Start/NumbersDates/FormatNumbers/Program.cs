// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting numerical data in .NET

int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}"); // 1234, 1,234.00, 1234.00, 1234
Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}"); // 1.234568E+003, 1,234.57, 1234.57, 1234.5678

// TODO: Add a number after the format to specify precision
Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}"); // 001234, 1,234.00, 1234.0, 1.23E+03


// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0]} {quarters[1]} {quarters[2]} {quarters[3]}"); // 1 2 3 4
Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}"); // 100000 150000 200000 225000
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}"); // 0.386 0.413 0.421 0.457


Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0], 12} {quarters[1], 12} {quarters[2], 12} {quarters[3], 12}");
Console.WriteLine($"{sales[0], 12:C0} {sales[1], 12:C0} {sales[2], 12:C0} {sales[3], 12:C0}"); 
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0], 12:P0} {intlMixPct[1], 12:P0} {intlMixPct[2], 12:P1} {intlMixPct[3], 12:P2}"); 


// FORMATTED RETURN:
// Sales by Quarter:
//            1            2            3            4
//     $100,000     $150,000     $200,000     $225,000
// International Sales:
//          39%          41%        42.1%       45.70%