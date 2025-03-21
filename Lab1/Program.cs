using System.Text.Encodings.Web;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1 Code to print my name and course title using Console.WriteLine() 
        Console.WriteLine("Roderick Vorhees IT-1050 - Lab 1");
        
        /* Name: Roderick Vorhees
        Title: IT-1050 - Lab 1 */
        
        //Declaring variables below
        int favNum = 0; // Declaring my favorite number

        string favLang = "Java"; // Declaring my favorite programming language

        double numProg = 1.5; // Declaring number of programs I have written

        bool proExp = false; // Declaring if I have programming experience

        const string schoolName = "Tri-C"; //Declaring a constant string for my school's name

        //Creating lines for output/print below

        Console.WriteLine("My favorite number is " + favNum + "."); // Displaying output of my favorite number

        Console.WriteLine("My favorite programming language is " + favLang + " because of its name."); // Displaying output for my favorite programming language

        Console.WriteLine("I have written " + numProg + " programs. This one and another in IT 1025."); // Displaying output for the number of programs I have written

        Console.WriteLine(proExp ? "I have programming experience." : "I have no programming experience."); // Displaying output for my programming experience

        Console.WriteLine("The school that I am currently attending is " + schoolName + "."); // Displaying output of the school name
    }
}
