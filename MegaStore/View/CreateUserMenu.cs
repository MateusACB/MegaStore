namespace MegaStore.View;

internal class CreateUserMenu : Menu
{
    public void CreateUser(Controller.Controller controller)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Create User Menu");
            Console.Write($"\nName: ");
            string name = Console.ReadLine();
            Console.Write($"Email: ");
            string email = Console.ReadLine();
            Console.Write($"Password: ");
            string password = Console.ReadLine();
            Console.Write($"Confirm Password: ");
            string confirmPassword = Console.ReadLine();

            if (password != confirmPassword)
            {
                Console.WriteLine("\nPasswords do not match.");
                Console.WriteLine("User creation failed.");
            }
            else if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("\nAll fields are required.");
                Console.WriteLine("User creation failed.");
            }
            else if (!email.Contains('@') || !email.Contains('.'))
            {
                Console.WriteLine("\nInvalid email format.");
                Console.WriteLine("User creation failed.");
            }
            else
            {
                if (controller.CreateUser(name, email, password))
                {
                    Console.WriteLine($"\nUser {email} created successfully.");
                    ConfirmReturnToPreviousMenu();
                    return;
                }
                else
                {
                    Console.WriteLine("User creation failed.");
                }
            }

            if (!TryAgainOrReturnToPreviousMenu())
            {
                return;
            }
        }
    }
}
