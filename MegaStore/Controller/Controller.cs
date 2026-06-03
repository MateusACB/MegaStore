using MegaStore.Model;
using MegaStore.Model.Product;
using MegaStore.Model.Product.DigitalProduct;

namespace MegaStore.Controller;

internal class Controller
{
    public List<User> users = new List<User>();
    public List<Product> products = new List<Product>();
    public List<Section> sections = new List<Section>();

    public void Start()
    {
        CreateStartUsers();
        CreateStartSections();
        CreateStartProducts();
    }

    public void CreateStartUsers()
    {
        users.Add(new User("John Doe", "a", "a"));
        users.Add(new User("John Doe", "john.doe@example.com", "password123"));
        users.Add(new User("Jane Smith", "jane.smith@example.com", "password456"));
    }

    public void CreateStartSections()
    {
        sections.Add(new Section("Grains"));
        sections.Add(new Section("Sweets"));
        sections.Add(new Section("Baking"));
        sections.Add(new Section("Digital Products"));
    }

    public void CreateStartProducts()
    {
        products.Add(new PhysicalProduct("Rice", "Golden Field", 5.17, sections[0], 2));
        products.Add(new PhysicalProduct("Rice", "Top Rice", 7, sections[0], 7));
        products.Add(new PhysicalProduct("Sugar", "Sweet Delight", 3.49, sections[1], 10));
        products.Add(new PhysicalProduct("Flour", "Baker's Choice", 2.99, sections[2], 11));
        products.Add(new DigitalProduct("E-book", "Tech Books", 9.99, sections[3], true));
        products.Add(new TimeLimitedDigitalProduct("Online Course", "LearnFast", 49.99, sections[3], true, 30));
    }

    public bool CreateUser(string name, string email, string password)
    {

        if (users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"\nError: A user with the email '{email}' already exists.");
            return false;
        }

        User user = new User(name, email, password);
        users.Add(user);

        return true;
    }
    public void ConfirmReturnToMenu()
    {
        Console.Write("Press any key to return to the Menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
