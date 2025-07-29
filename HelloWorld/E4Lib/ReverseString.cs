using System.Text;

namespace HelloWorld.E4Lib;

public static class ReverseString
{
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