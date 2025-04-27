namespace Lab7;

class Book
{
    private string title;
    private string author;

    public Book()  // Default Constructor
    {
        title = "Unknown Title";
    }

    public Book(string title) // Parameterized constructor
    {
        this.title = title;
    }

    public Book(string title, string author) // Overloaded constructor
    {
        this.title = title;
        this.author = author;
    }

    // Getters
    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    // Setters
    public void SetTitle(string newTitle)
    {
        this.title = newTitle;
    }

    public void SetAuthor(string newAuthor)
    {
        this.author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals"); 
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals

        Book book2 = new Book("Advanced C#"); // One parameter setter
        Console.WriteLine(book2.GetTitle()); // Output: Advanced C#

        Book book3 = new Book("The Alchemist", "Paulo Coehlo"); // Overloaded Setter
        Console.WriteLine(book3.GetTitle() + " by " + book3.GetAuthor()); // Output: The Alchemist by Paulo Coelho

        Book book4 = new Book();
        book4.SetTitle("The Diary of a Young Girl"); // Setting title
        book4.SetAuthor("Anne Frank"); // Setting author
        Console.WriteLine("Title: " + book4.GetTitle() + " | Author: " + book4.GetAuthor()); // Output
    }
}
