namespace HelloWorld.E4Lib;

public static class LengthOfLongestSubstring
{
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