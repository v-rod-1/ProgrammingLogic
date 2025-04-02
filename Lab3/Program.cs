namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Operator practice
            // Declaring variables
            int a = 10;
            int b = 5;
            int c = 15;

            // Check if a > b
            Console.WriteLine($"a > b: {a > b}");

            // Check if a < c
            Console.WriteLine($"a < c: {a < c}");

            // If else statement to check if a > b && c
            if (a > b && a > c)
            {
                Console.WriteLine("a > b && a > c: True");
            }
            else
            {
                Console.WriteLine("a > b && a > c: False");
            }

            // Check if a > b or a > c using || in shorthand variation
            Console.WriteLine(a > b || a > c ? "a > b || a > c: True" : "a > b || a > c: False");

            // Part 2: Boolean logic
            // Declaring variable
            bool isRaining = true;
            bool haveUmbrella = false;

            // If.. else statement. Using the ! operator to reverse the results of the true/false statement 
            if (isRaining && !haveUmbrella)
            {
                Console.WriteLine("Take an umbrella!");
            }
            else
            {
                Console.WriteLine("You're good to go!");
            }

            // Part 3: Movie ticket pricing
            // Asking the user to enter their age
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());  // Read and convert the input to a integer variable

            // Determining the ticket price category the user falls within using if... else statements 
            if (age < 5) // ages younger than 5
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else // age 65 or older
            {
                Console.WriteLine("Senior ticket: $6");
            }

            // Part 4: Using a switch statement
            // Asking the user to enter which day of the week it is using integers 1-7
            Console.Write("Please enter the day of the week using (1-7) starting from monday: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            // Using switch to display the corresponding day name
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}