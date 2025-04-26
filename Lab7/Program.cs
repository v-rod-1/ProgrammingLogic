namespace Lab7;

public class Book
{
    // Private fields
    private string title;
    private string author;

    // Default constructor
    public Book()
    {
        title = "Unknown Title";
    }

    // Parameterized constructor (title only)
    public Book(string title)
    {
        this.title = title;
    }

    // Overloaded constructor (title and author)
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Getters
    public string GetTitle() 
    {
        return this.title;
    }

    public string GetAuthor()
    {
        return this.author;
    }

    // Setters
    public void SetTitle(string title)
    {
        this.title = title;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output default - Unknown Title
        book1.SetTitle("C# Fundamentals"); // Setter for new title
        Console.WriteLine(book1.GetTitle());  // Output C# Fundamentals

        // Problem 2
        Book book2 = new Book("Learning C#"); // Parameterized setter
        Console.WriteLine(book2.GetTitle());  // Output: Learning C#

        // Problem 3
        Book book3 = new Book("Advanced C#", "John Doe"); // Overloaded setter
        Console.WriteLine("Title: " + book3.GetTitle());   // Output Advanced C#
        Console.WriteLine("Author: " + book3.GetAuthor()); // Output John Doe

        // Problem 4
        Book book4 = new Book();
        book4.SetTitle("Mastering C#"); // Updating title using setter
        book4.SetAuthor("Jane Smith"); // Updating author using setter
        Console.WriteLine("Title: " + book4.GetTitle());   // Output Mastering C#
        Console.WriteLine("Author: " + book4.GetAuthor()); // Output Jane Smith
    }
}
