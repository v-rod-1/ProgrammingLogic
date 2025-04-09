namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        // For Loop
        for (int v = 1; v <= 10; v++) // Starting from 1 increasing by increments of 1 and stopping at 10
        {
            Console.WriteLine(v); // Prints output 1-10
        }

        // Even numbers 1-20 using modulus
        for (int r = 1; r <= 20; r++) // starting from 1 increasing by 1 and stopping at 20
        {
            if (r % 2 == 0) // Using modulus to check if the answer is even. No remainder
            {
                Console.WriteLine(r); // Outputs even numbers from 1-20
            }
        }

        // While Loop counting backwards
        int countdown = 5; // Stating the starting point of 5
        while (countdown >= 1) // Creating a condition to stop at 1
        {
            Console.WriteLine(countdown--); //Outputs the countdown from 5 to 1 in decrements of 1
        }

        // Do/While with user input
        int number; // Creating a variable
        do // Creating a do statement
        {
            Console.Write("Enter a number greater than 100: "); // Prompt to gain user feedback
            number = Convert.ToInt32(Console.ReadLine()); // Converts user feedback into a integer
        } while (number <= 100); // Stating a condition that users number must be greater than 100
        Console.WriteLine("You've entered: " + number); // Output stating the user enter "this" number

        // While Loop to add multiples of 10 to 10 ending at 1000

        int i = 10; // Creating a variable
        while (i <= 1000) // Condition for variable stating it must be a number lesser than or equal to 1000
        {
            Console.WriteLine(i); // Printing value
            i += 10; // Adding ten to the variable and saving it to repeat loop
        }

        // Nested Loops to create a triangle

        for (int k = 1; k <= 10; k++) // For loop stating outer conditions
        {
            for (int c = 1; c <= k; c++) // For loop stating inner conditions
            {
                Console.Write("*"); // Printed output for inner loops
            }
            Console.WriteLine(); // Printed output for outer loop
        }
    }
}