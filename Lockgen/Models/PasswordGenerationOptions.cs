namespace Lockgen.Models;

/// <summary>
///     Model class that holds all the options a generated password can have
/// </summary>
public class PasswordGenerationOptions
{
    public int Size { get; init; }
    public bool UseUpper { get; init; }
    public bool UseLower { get; init; }
    public bool UseDigits { get; init; }
    public bool UseSpecial { get; init; }
}