namespace Lockgen;

/// <summary>
///     Class that is responsible for requesting the information needed to generate a password from a user
/// </summary>
public static class UserLogic
{
    /// <summary>
    ///     The function is responsible for retrieving the required number of characters to build the password
    /// </summary>
    /// <param name="message">The message that will be displayed to the user on the screen asking for the required number of characters of the password</param>
    /// <returns>Returns the number of characters for the password</returns>
    public static int GetPasswordSize(string message)
    {
        string? input = string.Empty;
        int size;
        
        while (int.TryParse(input, out size) == false)
        {
            Console.Write(message);
            input = Console.ReadLine();
        }
        
        Console.WriteLine($"Your password will be made up of {size} characters");

        return size;
    }

    /// <summary>
    ///     The function is responsible for confirming a specific option such as including uppercase/lowercase or other characters for password generation
    /// </summary>
    /// <param name="message">The message that will be displayed on the user's screen depending on what options he/she wants for generating the password</param>
    /// <returns>A binary decision (true/false) about a password option</returns>
    public static bool ConfirmPasswordWithOption(string message)
    {
        string? input = string.Empty;
        bool output = false;
        
        while (input.ToLower() != "y" && input.ToLower() != "n")
        {
            Console.Write(message);
            input = Console.ReadLine();

            if (input!.Equals("y"))
            {
                output = true;
            }
            else if (input.Equals("n"))
            {
                output = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
            }
        }

        return output;
    }
}