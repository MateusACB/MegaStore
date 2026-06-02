namespace MegaStore.Model;

internal class Section
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Name { get; private set; }
    private readonly List<Product> _products = new List<Product>();
    public int NumberOfProducts => _products.Count;

    public int TotalStock => (int)_products.Sum(p => p.Stock);


    public Section(string name)
    {
        Id = _nextId++;
        Name = name;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DisplaySection()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Section: {Name}");
        Console.WriteLine($"Products: {NumberOfProducts}");
        Console.WriteLine($"Total Stock: {TotalStock}");
    }
}