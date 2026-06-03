namespace MegaStore.Model.Product;

internal class Product
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Brand { get; private set; }
    public double Price { get; private set; }
    public Section Section { get; private set; }
    public virtual bool Available { get; protected set; }

    public Product(string name, string brand, double price, Section section)
    {
        Id = _nextId++;

        Name = name;
        Brand = brand;
        Price = price;
        Section = section;
        section.AddProduct(this);
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Section: {Section.Name}");
    }

    public void DisplayProductSummary()
    {
        Console.WriteLine($"    Id:{Id} - Name:{Name} - Brand:{Brand}");
    }
}
