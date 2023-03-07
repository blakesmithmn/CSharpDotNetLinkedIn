// Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for .NET Data Types

// Declare some types with values
int a = 1;
char c = 'A';
float f = 123.45f; 
decimal d = 400.85m;
int b = default; // default 0
bool tf = default; // default false

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// TODO: implicit type conversion
    // character + integer
    Console.WriteLine($"{c+a}");
    // results in character getting converted to a number
    Console.WriteLine($"{(char)(c + a)}"); // casting it to a character
    // returns 'B' 

    // Adding a floating point to an integer
    Console.WriteLine($"{f + a}"); // 124.45

    // Adding a floating point to a character
    Console.WriteLine($"{f + c}"); // 188.45


// TODO: Create an instance of a struct (which is a value type)
s s1;
s1.a = 5;
s1.b = false;

// Perform an operation on a struct
void StructOp(s theStruct) {
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}"); // original variables
StructOp(s1); // changed a COPY of the variables within the function
Console.WriteLine($"{s1.a}, {s1.b}"); // back to original values bc structs are value types

// TODO: Create an object instance of a class (which is a reference type)
MyClass cl = new MyClass{a=5, b=false};


// Perform an operation on the class
void ClassOp(MyClass theClass) {
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{cl.a}, {cl.b}"); // 5 true
ClassOp(cl); // 10 true
Console.WriteLine($"{cl.a}, {cl.b}"); // 10 true - because after the function completes - the values are changed bc it's a class REFERENCE TYPES

// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
// class is a reference type
class MyClass {
    public int a;
    public bool b;
}

// struct is a value type
struct s {
    public int a;
    public bool b;
}
