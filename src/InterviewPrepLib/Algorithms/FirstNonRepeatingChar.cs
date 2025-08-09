namespace InterviewPrepLib.Algorithms;

public static class FirstNonRepeatingChar
{   
    /// <summary>
    /// Finds the first non-repeating character in a given string.
    /// The method uses a dictionary to count occurrences of each character.
    /// Time Complexity: O(n), where n is the length of the input string.
    /// Space Complexity: O(1), as it uses a dictionary capped to the number of unique characters (e.g., 256 for ASCII).
    /// </summary>
    /// <param name="input">String to check for non-repeating characters.</param>
    /// <returns>The first non-repeating character or '\0' if none found.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    /// <exception cref="ArgumentException">Thrown when input is empty.</exception>
    public static char Execute(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
        if (input.Length == 0)
            throw new ArgumentException("Input string must contain characters.", nameof(input));
        if (input.Length == 1)
            return input[0];

        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        foreach (char letter in input)
        {
            var standardLetter = char.ToLower(letter);
            if (charCounts.ContainsKey(standardLetter))
                charCounts[standardLetter] += 1;
            else
                charCounts[standardLetter] = 1;
        }
        foreach (char letter in input)
        {
            var standardLetter = char.ToLower(letter);
            if (charCounts[standardLetter] == 1)
                return standardLetter;
        }
        return '\0';
    }
}