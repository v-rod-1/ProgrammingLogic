namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Declaring variables
        int myNum = 9;

        double myDouble = 3.14159265358979D;

        float myFloaty = 6.19f;

        char myLetter = 'v';

        bool  theBool = true;

        string lineString = "Don't rock the boat.";

        //Printing variables
        Console.WriteLine(myNum);

        Console.WriteLine(myDouble);

        Console.WriteLine(myFloaty);

        Console.WriteLine(myLetter);

        Console.WriteLine(theBool);

        Console.WriteLine(lineString);

        //Type casting
        double troubleDouble = 9.78;

        //Explicit casting (double -> int)
        int myInt = (int)troubleDouble; //9.78 becomes 9 after casting

        //C# conversions
        string myStringFromInt = Convert.ToString(myInt); //Int -> string

        string myStringFromBool = Convert.ToString(theBool); //Bool ->string

        // Printed values
        Console.WriteLine("double: " + troubleDouble);

        Console.WriteLine("int (from double): " + myInt);

        Console.WriteLine("int to string: " + myStringFromInt);

        Console.WriteLine("bool to string: " + myStringFromBool);

        //User input and type conversion

        Console.Write("Enter your name: "); //Prompt for user to enter their name
        string name = Console.ReadLine(); //Retrieves user's response and stores it as a variable

        Console.Write("Enter your age: "); //Prompt for user to enter their age
        int age = Convert.ToInt32(Console.ReadLine()); //Converts the user's age input to an integer

        Console.WriteLine("Hello, " + name + "! You are " + age + " years old."); //Greeting with user's name and age

        //Arithmetic operators
        //Declaring integers
        int num1 = 77;

        int num2 = 12;

        //Printing out the equation and results
        Console.WriteLine("Addition (77 + 10): " + (num1 + 10));

        Console.WriteLine("Addition (12 + 10): " + (num2 + 10));

        Console.WriteLine("Subtraction (12 - 2): " + (num2 - 2));

        Console.WriteLine("Subtraction (77 - 2): " + (num1 - 2));

        Console.WriteLine("Multiplication (77 * 3): " + (num1 * 3));

        Console.WriteLine("Multiplication (12 * 3): " + (num2 * 3));

        Console.WriteLine("Division (12 / 2): " + (num2 / 2));

        Console.WriteLine("Division (77 / 2): " + (num1 / 2)); //result is rounded down

        Console.WriteLine("Modulus (77 % 2): " + (num1 % 2));

        Console.WriteLine("Modulus (12 % 2): " + (num2 % 2));

        //Floating Point precision
        //Declaring float and double variables
        float floatPrecision = 1.123456789f;

        double doublePrecision = 1.123456789D;

        Console.WriteLine("Float precision: " + floatPrecision); //Outputs 1.1234568 omitting the 7 and 9

        Console.WriteLine("Double precision: " + doublePrecision); //Outputs full number

        //Increment and decrement
        //Declaring variable
        int myIntForFinalPart = 10;

        Console.WriteLine("Original value: " + myIntForFinalPart); //printing original value

        // Increment
        myIntForFinalPart++; //+1 to 10
        Console.WriteLine("After increment: " + myIntForFinalPart); // printed results

        // Decrement
        myIntForFinalPart--; //-1 to previous results
        Console.WriteLine("After decrement: " + myIntForFinalPart); //printed results

    }
}
