namespace HelloWorld.E4Lib;

public static class FirstNonRepeatingChar
{
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