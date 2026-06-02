namespace MegaStore.View;

public class Menu
{
    public void ConfirmReturnToPreviousMenu()
    {
        Console.Write("\nPress any key to return to the previous menu.");
        Console.ReadKey();
        Console.Clear();
    }

    public void ConfirmReturnToInitialMenu()
    {
        Console.Write("\nPress any key to return to the initial menu.");
        Console.ReadKey();
        Console.Clear();
    }

    public bool TryAgainOrReturnToPreviousMenu()
    {
        Console.Write("\nPress 1 to try again or any other key to return to the previous menu: ");
        string option = Console.ReadLine();
        Console.Clear();
        if (option == "1")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}