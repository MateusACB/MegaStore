namespace MegaStore.Model;
internal class User
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public User(string name, string email, string password)
    {
        Id = _nextId++;
        Name = name;
        Email = email;
        Password = password;
    }


}

