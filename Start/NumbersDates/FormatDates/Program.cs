// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting date information
using System.Globalization;
// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprFools:d}"); // 4/1/2025


// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprFools:D}"); // Tuesday, April 1, 2025


// TODO: 'f' Full date, short time
Console.WriteLine($"{AprFools:f}"); //Tuesday, April 1, 2025 1:23 PM

// TODO: 'F' Full date, long time
Console.WriteLine($"{AprFools:F}"); // Tuesday, April 1, 2025 1:23:30 PM

// TODO: 'g' General date and time
Console.WriteLine($"{AprFools:g}"); // 4/1/2025 1:23 PM


// TODO: 'G' General date and time
Console.WriteLine($"{AprFools:G}"); // 4/1/2025 1:23:30 PM


// TODO: Format using a specific CultureInfo
Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"))); // 01.04.2025 DD.MM.YYYY

// TODO: Defining custom date and time formats
Console.WriteLine($"{AprFools:dddd,MMMM,d yyyy}"); //Tuesday,April,1 2025
Console.WriteLine($"{AprFools:ddd, h:mm:ss tt}"); // Tue, 1:23:30 PM
Console.WriteLine($"{AprFools:MMM d yyyy}"); // Apr 1 2025
 
