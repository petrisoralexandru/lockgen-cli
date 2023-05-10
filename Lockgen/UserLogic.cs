namespace Lockgen;

/// <summary>
///     Class that is responsible for requesting the information needed to generate a password from a user
/// </summary>
public class UserLogic
{
    /// <summary>
    ///     The function is responsible for retrieving the required number of characters to build the password
    /// </summary>
    /// <param name="message">The message that will be displayed to the user on the screen asking for the required number of characters of the password</param>
    /// <returns>Returns the number of characters for the password</returns>
    public static int GetPasswordSize(string message)
    {
        string? output = string.Empty;
        int size = 0;
        
        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
            int.TryParse(output, out size);
        }
        
        Console.WriteLine($"Your password will be made up of {size} characters");

        return size;
    }
}