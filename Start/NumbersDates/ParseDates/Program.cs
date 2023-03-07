// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing dates from strings

// Collection of various date string formats to attempt parsing
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes) {
    DateTime result;
    // TODO: Use the static class function TryParse to try parsing the dates

    if(DateTime.TryParse(datestr, out result)){
        Console.WriteLine($"{datestr, -25}, gets parsed as: {result}");
    }
    else {
        Console.WriteLine($"Could not parse '{datestr}");
    }
}

// January 1, 2025 9:30 AM  , gets parsed as: 1/1/2025 9:30:00 AM
// 1/1/2025                 , gets parsed as: 1/1/2025 12:00:00 AM
// Jan 1, 2025 7:30PM       , gets parsed as: 1/1/2025 7:30:00 PM
// Jan 1, 25                , gets parsed as: 1/1/2025 12:00:00 AM
// 1/2025                   , gets parsed as: 1/1/2025 12:00:00 AM
// 1/1 7PM                  , gets parsed as: 1/1/2023 7:00:00 PM
// Could not parse 'Jan 1 '15
