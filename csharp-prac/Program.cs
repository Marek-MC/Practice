// Created with: `dotnet new console`
// Activate with: `dotnet run`
Console.WriteLine("Hello world!");

// Variables and Data Types.

var myVar = "Don't use these."; // ArgumentNullException implicit way of declaring variables.
const string myConst = "Nice."; // Constants must be explicitly typed. 
int myInt = 1; // Int: Stores whole numbers.
double myDuo = 3.5; // Double: Stores floating point numbers w/ decimals.
char myChar = 'S'; // Char: Stores a single digit value, a character.
string myStr = ", S is for Savis, the S tier feline of the cosmos."; // String: Stores a string of text. 
bool myBool = true; // Bool: Is either True or False.
int? myNull = null; // Variables are non-nullable unless written with "?".

Console.WriteLine(myInt + myDuo);
Console.WriteLine(myChar + myStr);
Console.WriteLine(myBool);
Console.WriteLine(myNull); // Displays empty space (nice.)

// Data Casting

// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

int myInteger = 9;
double myDouble = myInteger; // Automatic casting: Int to double.

Console.WriteLine(myInteger); // Outputs 9
Console.WriteLine(myDouble); // Outputs 9


// User Inputs

Console.WriteLine("Username?");

// Create a string variable and get user input from the keyboard and store it in the variable.
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value.
Console.WriteLine("Username is: " + userName);



// If Else Statements

Console.WriteLine("Age?");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Underage.");
}
else if (age > 60)
{
    Console.WriteLine("This is a senior.");
}
else
{
    Console.WriteLine("Not underage.");
};


// Switch Cases

var variable = 'a';

switch (variable)
{
    case 'a':
        Console.WriteLine("Case A ran successfully");
        break;

    case 'b':
        Console.WriteLine("Case B ran successfully");
        break;

    default:
        Console.WriteLine(variable);
        break;
}


// Loops