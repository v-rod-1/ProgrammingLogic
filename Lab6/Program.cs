using System;

class Car
{
public string model;
public string color;
public int year;
public void Start() // Method with no parameters
    {
        Console.WriteLine("The car is starting.");
    }
public void Drive(int miles) // Method with parameters
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

public string GetDescription() // Method with a return value
    {
        return $"{year} {color} {model}";
    }

public void Repaint(string newColor) // Method that updates a field
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {color}.");
    }

  // Example method to display car details. You can use this as an example for the other methods.
public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method

    myCar.Start();  // Calling the Start method

    myCar.Drive(50); // Calling the Drive method while stating mileage

    string description = myCar.GetDescription(); // Creating a string value that calls the GetDescription method

    Console.WriteLine(description); // Displaying GetDescription method

    myCar.Repaint("Red"); // Calling the Repaint method

    Console.WriteLine(myCar.color); // Outputting the new color
  }
}