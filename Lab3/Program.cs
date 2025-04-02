namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Operator Practice
            // Declaring variables
            int a = 10;
            int b = 5;
            int c = 15;

            // Check if a > b
            Console.WriteLine($"a > b: {a > b}");

            // Check if a < c
            Console.WriteLine($"a < c: {a < c}");

            // If else statement to check if a > b and c
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

            // Part 2: Boolean Logic
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

        }
    }
}