using System.Text;

namespace HelloWorld.E4Lib;

public static class ReverseString
{
    /// <summary>
    /// Reverses the given string.
    /// If the input is null, an ArgumentNullException is thrown.
    /// If the input string is empty or has length 1, it is returned immediately as reversal is the same.
    /// The method constructs the reversed string by appending characters from the end of the input string.
    /// Uses StringBuilder for efficient string concatenation.
    /// Time Complexity: O(n), where n is the length of the input string.
    /// Space Complexity: O(n), as it creates a new string of the same length as the input.
    /// </summary>
    /// <param name="input">The input string to reverse.</param>
    /// <returns>The reversed string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static string Execute(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
        if (input.Length == 0 || input.Length == 1)
            return input;

        var reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        return reversed.ToString();
    }
}