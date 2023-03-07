// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
// built ins for dotnet 6+ include stuff like console 
Console.WriteLine("What's your name?");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course, {response}");
// using built in environment variables to see what system / platform we are running on!
OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);
