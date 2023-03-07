// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
// using(StreamWriter sw = File.CreateText(filename)){
//     sw.WriteLine("This is a text file we made using C sharp ! Kinda neat huh");
// };

// TODO: Determine if a file exists
// checks if file exists and prints to console
Console.WriteLine(File.Exists(filename));
if(File.Exists(filename)){
    // if file exists delete it
    File.Delete(filename);
}
else {
    // else create a new file using this function
    using(StreamWriter sw = File.CreateText(filename)){
        sw.WriteLine("This is a text file we made using C sharp ! Kinda neat huh");
    };
}
Console.WriteLine(File.Exists(filename));

