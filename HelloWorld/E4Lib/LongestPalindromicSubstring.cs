namespace HelloWorld.E4Lib;

public class LongestPalindromicSubstring {

    /// <summary>
    /// Finds the Longest Palindrome substring in a given string. Two pointer, expand around center solution.
    /// I can probably do one-pass solution, but I use two while loops for ease of writing and readability.
    /// Time Complexity: O(n^2) worst-case. For each char in input string, check every other char.
    /// Space Complexity: O(k) or O(1) - strings are immutable, so I believed it would be O(n) worst case, where n = input.Length
    /// however the substring is generally not n length, and further research says this would be classified as
    /// O(k), where k = length of substring, or O(1), as it's in "output space"
    /// </summary>
    /// <param name="input">String to check for longest palindrome substring</param>
    /// <returns>The longest substring in string</returns>
    /// <exception cref="ArgumentNullException">String is null</exception>
    /// <exception cref="ArgumentException">String is empty</exception>
    public static string Execute(string input)
    {
        #region Input Validation
        if (input is null)
        {
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
        }
        if (input.Length == 0)
        {
            throw new ArgumentException("Input string cannot be empty.", nameof(input));
        }
        if (input.Length == 1)
        {
            return input;
        }
        #endregion

        int start = 0, maxLength = 1;

        for (int center = 1; center < input.Length - 1; center++)
        {
            // Odd-Length palindrome check
            int left = center;
            int right = center;
            while (left >= 0 && right < input.Length && input[left] == input[right])
            {

                if ((right - left + 1) > maxLength)
                {
                    start = left;
                    maxLength = right - left + 1;
                }
                left--;
                right++;
            }

            // Even-Length palindrome check
            left = center;
            right = center + 1;
            while (left >= 0 && right < input.Length && input[left] == input[right])
            {
                if ((right - left + 1) > maxLength)
                {
                    start = left;
                    maxLength = right - left + 1;
                }
                left--;
                right++;
            }

        }
        return input.Substring(start, maxLength);
    }
}