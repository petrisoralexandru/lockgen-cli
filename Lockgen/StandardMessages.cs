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
}