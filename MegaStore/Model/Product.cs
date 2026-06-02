namespace MegaStore.Model;

internal class Product
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Brand { get; private set; }
    public double Price { get; private set; }
    public Section Section { get; private set; }
    public double Stock { get; private set; }

    public Product(string name, string brand, double price, Section section, double quantityAvailable)
    {
        Id = _nextId++;

        Name = name;
        Brand = brand;
        Price = price;
        Section = section;
        Stock = quantityAvailable;
        section.AddProduct(this);
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Section: {Section.Name}");
        Console.WriteLine($"Stock: {Stock}");
    }

    public void DisplayProductSummary()
    {
        Console.WriteLine($"    Id:{Id} - Name:{Name} - Brand:{Brand} - Quantity:{Stock}");
    }
}
