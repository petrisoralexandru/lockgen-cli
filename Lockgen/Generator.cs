using System.Security.Cryptography;
using System.Text;

namespace Lockgen;

/// <summary>
///     The password generator main class that contains the business logic
/// </summary>
public static class Generator
{
    private static readonly string UpperCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly string LowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
    private static readonly string Digits = "1234567890";
    private static readonly string SpecialCharacters = @"!@#$%^&*()_-+=`~""':;<>,.?/|\()[]{}+*/=<>$€";
    
    /// <summary>
    ///     The method responsible for generating the password
    /// </summary>
    /// <param name="size">Number of characters of the password</param>
    /// <param name="useUpper">Option that allows the password to contain capital letters</param>
    /// <param name="useLower">Option that allows password to contain lower case letters</param>
    /// <param name="useDigits">Option that allows password to contain digits</param>
    /// <param name="useSpecial">Option that allows password to contain special characters</param>
    /// <returns>The generated password as a string</returns>
    public static string GeneratePassword(int size, bool useUpper, bool useLower, bool useDigits, bool useSpecial)
    {
        byte[] data = new byte[size * 10];
        RandomNumberGenerator.Fill(data);

        StringBuilder passwordOptions = new();

        if (useUpper) passwordOptions.Append(UpperCharacters);
        if (useLower) passwordOptions.Append(LowercaseCharacters);
        if (useDigits) passwordOptions.Append(Digits);
        if (useSpecial) passwordOptions.Append(SpecialCharacters);

        StringBuilder password = new();
        
        for (int i = 0; i < size; i++)
        {
            long random = BitConverter.ToUInt32(data, i * 10) % passwordOptions.Length;
            password.Append(passwordOptions[(int)random]);
        }
        
        return password.ToString();
    }
}