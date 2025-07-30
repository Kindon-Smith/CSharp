namespace HelloWorld.E4Lib;

public static class LengthOfLongestSubstring
{
    /// <summary>
    /// Finds the length of the longest substring without repeating characters in the given string.
    /// The method uses a sliding window approach with a HashSet to track characters in the current
    /// window. This allows for efficient checking of duplicate characters.
    /// ArgumentNullException is thrown if the input string is null.
    /// Time Complexity: O(n), where n is the Length of the input string.
    /// Space Complexity: O(1) to O(n), arguably O(1) since the set will contain at most 256 characters (ASCII).
    /// </summary>
    /// <param name="input">The string to analyze.</param>
    /// <returns>The length of the longest substring without repeating characters.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static int Execute(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
        if (input.Length == 1)
            return 1;

        int left = 0;
        HashSet<char> windowStringSet = new HashSet<char>();
        int max = 0;

        for (int right = 0; right < input.Length; right++)
        {
            if (windowStringSet.Contains(input[right]))
            {
                while (input[left] != input[right])
                {
                    windowStringSet.Remove(input[left]);
                    left++;
                }
                windowStringSet.Remove(input[left]);
                left++;
            }
            windowStringSet.Add(input[right]);
            max = Math.Max(max, right - left + 1);
        }
        return max;
    }
}