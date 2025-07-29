namespace HelloWorld.E4Lib;

public static class CountVowels
{
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