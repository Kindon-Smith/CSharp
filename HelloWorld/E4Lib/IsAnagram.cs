namespace HelloWorld.E4Lib;

public static class AnagramCheck
{
    public static bool Execute(string input1, string input2)
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