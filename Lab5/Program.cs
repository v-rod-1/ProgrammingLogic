using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Declaring a string array for the 4 seasons
        string[] seasons = new string[] {"Spring", "Summer", "Fall", "Winter"}; 

        foreach(string sez in seasons) // sez is a new variable that represents each element in the array
        {
            Console.WriteLine("Season: " + sez); // Outputting seasons
        }
        // Declaring a string array for the 7 days of the week
        string[] dayS = new string[7];

        dayS[0] = "Monday";

        dayS[1] = "Tuesday";

        dayS[2] = "Wednesday";

        dayS[3] = "Thursday";

        dayS[4] = "Friday";

        dayS[5] = "Saturday";

        dayS[6] = "Sunday";

        int number;

        do // Creating a do statement
        {
            Console.Write("Enter a number (1-7): "); // Prompt to gain user feedback
            number = Convert.ToInt32(Console.ReadLine()); // Converts user feedback into a integer
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 7."); // Output for invalid input
            }
        } while (number < 1 || number > 7); // Loop again if input is out of range
        
        Console.WriteLine("That day is: " + dayS[number - 1]); //Displays the day the user inputs
        // Declaring two string arrays for authors and books
        string[] authors = new string[] {"Daniel Khaneman", "W. Timothy Gallwey", "Miyamoto Musashi"};

        string[] books = new string[] {"Thinking, Fast & Slow", "The Inner Game of Tennis", "The Book of Five Rings"};
        // Using a for loop to print each book and corresponding author
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Book " + (i + 1) + ": " + books[i] + " by " + authors[i]); // Output for each book and author
        }
         // Declaring temperatures array
        int[] temperatures = { 65, 72, 78, 70, 68 };

        Array.Sort(temperatures); // Sort the array in ascending order

        Console.Write("Sorted Temperatures: ");
        
        foreach (int temp in temperatures)
        {
            Console.Write(temp + " "); // Print the sorted temperatures
        } 

        Console.WriteLine(); // Move to the next line after printing all temperatures

        // Print the highest and lowest temperatures
        Console.WriteLine("Highest Temperature: " + temperatures[4]); 

        Console.WriteLine("Lowest Temperature: " + temperatures[0]);
    
        // Declaring countdown array
        int[] countdown = { 1, 2, 3, 4, 5 };

        Array.Reverse(countdown); // Reverse the array

        Console.Write("Countdown: "); // Outputs the phrase "Countdown:"

        foreach (int num in countdown) // Grabs the numbers from countdown
        
        Console.Write(num + " "); // Outputs the numbers in descending order from the foreach statement

        Console.WriteLine(); // Moves to next line to make terminal look cleaner
    }
}
