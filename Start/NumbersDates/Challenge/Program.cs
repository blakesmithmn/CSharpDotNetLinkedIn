// console application
// reads user input of date time strings
// parses input 
// checks to see if that day has gone by:
    // if it has gone by - how long ago?
    // if it hasn't gone by - how many days until?
    // if it's formatted incorrectly provide user feedback


// reads and stores their response
string userinput = "";

// holding the current date with time of 12:00
DateTime today = DateTime.Today;

do {
    // prints a prompt for the user
    Console.WriteLine("Enter a Date, or type 'exit'");
    userinput = Console.ReadLine();

    // if the user types 'exit' leave the app

    if(userinput == "exit"){
        break;
    }

    DateTime parsedDate ; 
    TimeSpan ts;

    if(DateTime.TryParse(userinput, out parsedDate)){
        if(parsedDate < today){
            // if the date has gone by - indicate how long it has been since
            ts = today - parsedDate;
            Console.WriteLine($"That date went by {ts.Days} days ago!");
        }
        else if (parsedDate == today) {
            Console.WriteLine($"That date is today!");
        }
        else {
            // if the date has NOT gone by - indicate how long until it happens
            ts = parsedDate - today;
            Console.WriteLine($"That date will be in {ts.Days} days!");
        }
       
    }
    else {
        Console.WriteLine($"The Date you entered {userinput} is invalid - try again");
    }
} while (userinput != "exit");