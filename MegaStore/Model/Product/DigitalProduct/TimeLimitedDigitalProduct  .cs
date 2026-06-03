namespace MegaStore.Model.Product.DigitalProduct;

internal class TimeLimitedDigitalProduct : DigitalProduct
{
    public bool HasTimeLimit { get; } = true;
    public int DaysToAccess { get; private set; }
    public bool AvailableToUse => DateTime.Now < ActivationDate.AddDays(DaysToAccess) && IsActivated;

    public TimeLimitedDigitalProduct(string name, string brand, double price, Section section, bool availableToBuy, int daysToAccess)
        : base(name, brand, price, section, availableToBuy)
    {
        DaysToAccess = daysToAccess;
    }
}
