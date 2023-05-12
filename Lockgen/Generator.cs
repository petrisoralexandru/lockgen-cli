using System.Security.Cryptography;
using System.Text;
using Lockgen.Models;

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
    /// <param name="options">Object containing the options of a generated password</param>
    /// <returns>The generated password as a string</returns>
    public static string GeneratePassword(PasswordGenerationOptions options)
    {
        byte[] data = new byte[options.Size * 10];
        RandomNumberGenerator.Fill(data);

        StringBuilder passwordOptions = new();

        if (options.UseUpper) passwordOptions.Append(UpperCharacters);
        if (options.UseLower) passwordOptions.Append(LowercaseCharacters);
        if (options.UseDigits) passwordOptions.Append(Digits);
        if (options.UseSpecial) passwordOptions.Append(SpecialCharacters);

        StringBuilder password = new();
        
        for (int i = 0; i < options.Size; i++)
        {
            long random = BitConverter.ToUInt32(data, i * 10) % passwordOptions.Length;
            password.Append(passwordOptions[(int)random]);
        }
        
        return password.ToString();
    }
}