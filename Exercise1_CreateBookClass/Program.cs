using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: ₹{Price}");
        Console.WriteLine("------------------------");
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("C# Basics", "Devyansh Malhotra", 499.99);
        Book book2 = new Book("Advanced C#", "Jane Doe", 799.50);

        book1.DisplayDetails();
        book2.DisplayDetails();
    }
}
