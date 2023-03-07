// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine(now); // 3/7/2023 2:50:02 PM

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine(today); // 3/7/2023 12:00:00 AM

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dt); // 3/7/2023
Console.WriteLine(tm); // 2:50 PM

// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek); // Tuesday
Console.WriteLine(today.DayOfYear); // 66

// TODO: Dates also have methods to change their values
now = now.AddDays(5);
now = now.AddHours(9);
now = now.AddMonths(1);

Console.WriteLine(now); // 4/13/2023 12:01:23 AM



// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);

TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval); // 90.00:00:00 (90 days)

// TODO: Dates can be compared using regular operators
Console.WriteLine($"{NewYears < AprilFools}"); // TRUE
Console.WriteLine($"{NewYears > AprilFools}"); // FALSE