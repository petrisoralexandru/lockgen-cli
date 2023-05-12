namespace Lockgen;

/// <summary>
///     Class responsible for providing informal messages to the user
/// </summary>
public static class StandardMessages
{
    /// <summary>
    ///     The method is responsible for displaying an information and welcome message to the user to the application
    /// </summary>
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to Lockgen CLI, the efficient and streamlined password generator application!");
        Console.WriteLine(
            "Harnessing the power of the command line interface, Lockgen CLI offers a lightweight and lightning-fast alternative to the Lockgen application.");
    }

    /// <summary>
    ///     The method is responsible for displaying recommendations for a secure password.
    /// </summary>
    public static void ShowPasswordGuidelines()
    {
        Console.WriteLine();
        Console.WriteLine(
            "To create a secure and random password, please specify the desired number of characters for your password.");
        Console.WriteLine(
            "To ensure optimal security, we recommend that you use a minimum of 4 characters and a maximum of 40 characters for your password.");
        Console.WriteLine();
        Console.WriteLine("Passwords constructed of specific number of character are considered: ");
        Console.WriteLine("4-6 characters - Weak");
        Console.WriteLine("7-8 characters - Average");
        Console.WriteLine("9/9+ characters - Strong");
    }
}