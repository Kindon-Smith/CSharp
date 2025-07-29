using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace HelloWorld.Exercises;

public class Exercise4
{
    /// <summary>
    /// Finds the maximum value in an array of integers.
    /// Throws ArgumentException if input is null.
    /// Returns the only value if array length is 1.
    /// </summary>
    public static int FindMax(int[] numbers)
    {
        if (numbers is null)
        {
            throw new ArgumentNullException(nameof(numbers),"Input array cannot be null.");
        }
        if (numbers.Length == 0)
        {
            throw new ArgumentNullException("Input array cannot be empty.", nameof(numbers));
        }
        if (numbers.Length == 1)
        {
            return numbers[0];
        }

        int maxValue = int.MinValue;
        foreach (int number in numbers)
        {
            maxValue = number > maxValue ? number : maxValue;
        }
        return maxValue;
    }

    public static string ReverseString(string input)
    {
        if (input is null)
        {
            throw new ArgumentNullException(nameof(input),"Input string cannot be null.");
        }
        if (input.Length == 0 || input.Length == 1)
        {
            return input;
        }

        var reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        return reversed.ToString();
    }

    public static int CountVowels(string input)
    {
        if (input is null)
        {
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
        }

        int vowelCount = 0;
        foreach (char letter in input) {
            if (Vowels.Contains(char.ToLower(letter)))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
    private static readonly HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };


    public static char FirstNonRepeatingChar(string input)
    {
        if (input is null)
        {
            throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
        }
        if (input.Length == 0)
        {
            throw new ArgumentException("Input string must contain characters.", nameof(input));
        }
        if (input.Length == 1)
        {
            return input[0];
        }

        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        
        foreach (char letter in input)
        {
            var standardLetter = char.ToLower(letter);
            if (charCounts.ContainsKey(standardLetter))
            {
                charCounts[standardLetter] += 1;
            }
            else
            {
                charCounts[standardLetter] = 1;
            }
        }
        foreach (char letter in input)
        {
            var standardLetter = char.ToLower(letter);
            if (charCounts[standardLetter] == 1)
            {
                return standardLetter;
            }
        }
        return '\0';
    }
    public static void Run()
    {
        /*string catDog = "catDog";
        var reversedCatDog = ReverseString(catDog);
        /*Console.WriteLine(reversedCatDog);
        Console.WriteLine(ReverseString(""));
        Console.WriteLine(ReverseString("1"));

        Console.WriteLine(CountVowels("Hello"));
        Console.WriteLine(CountVowels("Potatosandwichupinmygums"));*/

        Console.WriteLine(FirstNonRepeatingChar("Hello"));
        Console.WriteLine(FirstNonRepeatingChar("Hhohh"));

    }
}