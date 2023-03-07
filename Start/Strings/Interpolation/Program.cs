// LinkedIn Learning Course .NET Programming with C# by Joe Marini

// String Interpolation is a feature that enables the easy insertion of data
// and expression values into a string variable

int a = 100;
float b = 250.0f;
string c = "CSharp";

// String output the old way - using placeholders
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c); //The values are 100, 250, and CSharp

// TODO: Using string interpolation, the code is much easier to read
Console.WriteLine($"The values are {a}, {b}, and {c}"); //The values are 100, 250, and CSharp

// TODO: Interpolated strings can contain expressions as well
Console.WriteLine($"(a+b)/b is {(a+b)/b}");  // (a+b)/b is 1.4


Console.WriteLine($"{c} in upper-case is: {c.ToUpper()}"); // CSHARP

// TODO: Complex objects can be embedded in strings this way as well
DateTime now = DateTime.Now;

Console.WriteLine($"Today is {now}"); // Today is 3/7/2023 12:45:43 PM
