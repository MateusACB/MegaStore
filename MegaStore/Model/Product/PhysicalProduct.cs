namespace MegaStore.Model.Product;

internal class PhysicalProduct : Product
{
    public int Weight { get; private set; }
    public int Length { get; private set; }
    public double Stock { get; private set; }
    public override bool Available => Stock > 0;

    public PhysicalProduct(string name, string brand, double price, Section section, double stock)
        : base(name, brand, price, section)
    {
        Stock = stock;
    }
}
