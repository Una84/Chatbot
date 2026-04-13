public static class InputHandler
{
    public static string ValidateName(string name)
    {
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("⚠️ Name cannot be empty. Enter your name: ");
            name = Console.ReadLine();
        }

        return name;
    }
}