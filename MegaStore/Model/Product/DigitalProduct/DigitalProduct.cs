namespace MegaStore.Model.Product.DigitalProduct;

internal class DigitalProduct : Product
{
    public bool IsActivated { get; private set; }

    public DateTime ActivationDate { get; private set; }
    public virtual bool AvailableToBuy { get; private set; }

    public DigitalProduct(string name, string brand, double price, Section section, bool availableToBuy)
        : base(name, brand, price, section)
    {
        IsActivated = false;
        AvailableToBuy = availableToBuy;
    }

    public void Activate()
    {
        if (!IsActivated)
        {
            IsActivated = true;
            ActivationDate = DateTime.Now;
        }
    }
}