// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename)); // 3/7/2023 5:15:17 PM
Console.WriteLine(File.GetLastWriteTime(filename)); // 3/7/2023 5:15:17 PM
Console.WriteLine(File.GetLastAccessTime(filename)); // 3/7/2023 5:15:17 PM

File.SetAttributes(filename, FileAttributes.ReadOnly);

Console.WriteLine(File.GetAttributes(filename));

// TODO: We can also get general information using a FileInfo 
try {
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine($"{fi.Length}"); // 22
    Console.WriteLine($"{fi.Directory}"); // shows where this file exists
    Console.WriteLine($"{fi.IsReadOnly}"); // True
}
catch (Exception e){
    Console.WriteLine($"Exception: {e}");
}

// TODO: File information can also be manipulated
DateTime dt = new DateTime(2020, 7, 1);
File.SetCreationTime(filename, dt);
Console.WriteLine(File.GetCreationTime(filename)); // 7/1/2020 12:00:00 AM
