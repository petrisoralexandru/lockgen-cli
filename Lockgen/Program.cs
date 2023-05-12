using Lockgen.Models;
using TextCopy;

namespace Lockgen;

public class Program
{
    private static void Main()
    {
        StandardMessages.WelcomeUser();
        StandardMessages.ShowPasswordGuidelines();
        Console.WriteLine();

        PasswordGenerationOptions passwordGenerationOptions = new()
        {
            Size = UserLogic.GetPasswordSize("What is the desired number of characters for the password?: "),
            UseUpper = UserLogic.ConfirmPasswordWithOption("Do you want your password to contain upper letters? (y/n): "),
            UseLower = UserLogic.ConfirmPasswordWithOption("Do you want your password to contain lowercase letters? (y/n): "),
            UseDigits = UserLogic.ConfirmPasswordWithOption("Do you want your password to contain digits? (y/n): "),
            UseSpecial = UserLogic.ConfirmPasswordWithOption("Do you want your password to contain special characters? (y/n): ")
        };
        
        string generatedPassword = Generator.GeneratePassword(passwordGenerationOptions);

        Console.WriteLine();
        Console.Write($"Your password is {generatedPassword} \n");
        
        ClipboardService.SetText(generatedPassword);
        Console.Write("The password has been copied to the clipboard. You can use it using the key combination CTRL+V.");
    }
}