using TextCopy;

namespace Lockgen;

public class Program
{
    private static void Main()
    {
        StandardMessages.WelcomeUser();
        StandardMessages.ShowPasswordGuidelines();
        Console.WriteLine();
        
        int passwordSize = UserLogic.GetPasswordSize("What is the desired number of characters for the password?: ");

        bool cotainsUpperLetters =
            UserLogic.ConfirmPasswordWithOption("Do you want your password to contain upper letters? (y/n): ");

        bool cotainsLowerLetters =
            UserLogic.ConfirmPasswordWithOption("Do you want your password to contain lowercase letters? (y/n): ");

        bool containsDigits =
            UserLogic.ConfirmPasswordWithOption("Do you want your password to contain digits? (y/n): ");

        bool containsSpecialSymbols =
            UserLogic.ConfirmPasswordWithOption("Do you want your password to contain special characters? (y/n): ");

        string generatedPassword = Generator.GeneratePassword(passwordSize, cotainsUpperLetters, cotainsLowerLetters,
            containsDigits, containsSpecialSymbols);

        Console.WriteLine();
        Console.Write($"Your password is {generatedPassword} \n");
        
        ClipboardService.SetText(generatedPassword);
        Console.Write("The password has been copied to the clipboard. You can use it using the key combination CTRL+V.");
    }
}