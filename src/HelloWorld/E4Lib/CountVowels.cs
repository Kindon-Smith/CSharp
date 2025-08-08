namespace HelloWorld.E4Lib;

public static class CountVowels
{
    /// <summary>
    /// Counts the number of vowels in the given string.
    /// Vowels are defined as 'a', 'e', 'i', 'o', 'u'.
    /// Time Complexity: O(n), where n is the length of the input string.
    /// Space Complexity: O(1), as it uses a fixed-size HashSet for vowels.
    /// </summary>
    /// <param name="input">The string to count vowels in.</param>
    /// <returns>The count of vowels in the input string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    private static readonly HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    public static int Execute(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");

        int vowelCount = 0;
        foreach (char letter in input)
        {
            if (Vowels.Contains(char.ToLower(letter)))
                vowelCount++;
        }
        return vowelCount;
    }
}