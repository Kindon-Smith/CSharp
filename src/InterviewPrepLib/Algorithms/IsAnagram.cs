namespace InterviewPrepLib.Algorithms;

public static class AnagramCheck
{
    /// <summary>
    /// Checks if two strings are anagrams of each other without sorting.
    /// An anagram is a word or phrase formed by rearranging the letters of a different
    /// word or phrase, typically using all the original letters exactly once.
    /// If the input strings are null, an ArgumentNullException is thrown.
    /// Time Complexity: O(n), where n is the length of the input strings. Program ensures
    /// sizes match before proceeding with character counting.
    /// Space Complexity: O(1), as it uses a dictionary capped to the number of unique characters (e.g., 256 for ASCII).
    /// </summary>
    /// <param name="input1">String to be compared</param>
    /// <param name="input2">Second string to be compared.</param>
    /// <returns>True or False</returns>
    /// <exception cref="ArgumentNullException">Thrown when either input is null.</exception>
    public static bool Execute(string? input1, string? input2)
    {
        if (input1 is null || input2 is null)
        {
            var nullInput = input1 == null ? nameof(input1) : nameof(input2);
            throw new ArgumentNullException(nullInput, "Input string cannot be null.");
        }
        if (input1.Length != input2.Length)
            return false;

        Dictionary<char, int> letterCounts = new Dictionary<char, int>();
        for (int i = 0; i < input1.Length; i++)
        {
            var letter1 = input1[i];
            var letter2 = input2[i];
            if (letterCounts.ContainsKey(letter1))
                letterCounts[letter1] += 1;
            else
                letterCounts[letter1] = 1;

            if (letterCounts.ContainsKey(letter2))
                letterCounts[letter2] -= 1;
            else
                letterCounts[letter2] = -1;
        }
        return letterCounts.Values.All(count => count == 0);
    }
}