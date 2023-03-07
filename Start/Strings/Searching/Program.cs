// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine($"{teststr.Contains("fox")}"); // takes casing into account to this would be false
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}"); // would return true after ignoring case


// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine($"{teststr.StartsWith("the")}"); // false
Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}"); // true

Console.WriteLine($"{teststr.EndsWith("dog")}"); // false 
Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase )}"); // true


// TODO: IndexOf, LastIndexOf finds the index of a substring
// -1 if it isn't found
Console.WriteLine($"{teststr.IndexOf("the")}"); // 31
Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}"); // 0

Console.WriteLine($"{teststr.LastIndexOf("the")}"); //  31



// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;

Console.WriteLine($"{String.IsNullOrEmpty(str1)}"); // true
Console.WriteLine($"{String.IsNullOrEmpty(str3)}"); // true
Console.WriteLine($"{String.IsNullOrWhiteSpace(str2)}"); // true
