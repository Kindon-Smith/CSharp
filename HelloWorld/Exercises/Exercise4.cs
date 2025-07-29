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

    public static bool AnagramCheck(string input1, string input2)
    {
        if(input1 is null || input2 is null)
        {
            var nullInput = input1 == null ? nameof(input1) : nameof(input2);
            throw new ArgumentNullException(nullInput, "Input string cannot be null.");
        }
        if (input1.Length != input2.Length)
        {
            return false;
        }

        // A few ways:
        // dictionary containing char : int (for each char, count total)
        // likely more complex memory usage
        // 
        // sorting - sorted strings will be identical if anagrams. likely a more
        // complex runtime to sort two strings

        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        for (int i = 0; i < input1.Length; i++)
        {
            var letter1 = input1[i];
            var letter2 = input2[i];
            if (letterCounts.ContainsKey(letter1))
            {
                letterCounts[letter1] += 1;
            }
            else
            {
                letterCounts[letter1] = 1;
            }

            if (letterCounts.ContainsKey(letter2))
            {
                letterCounts[letter2] -= 1;
            }
            else
            {
                letterCounts[letter2] = -1;
            }
        }
        return letterCounts.Values.All(count => count == 0);
    }
    public static void Run()
    {
        /*string catDog = "catDog";
        var reversedCatDog = ReverseString(catDog);
        /*Console.WriteLine(reversedCatDog);
        Console.WriteLine(ReverseString(""));
        Console.WriteLine(ReverseString("1"));

        Console.WriteLine(CountVowels("Hello"));
        Console.WriteLine(CountVowels("Potatosandwichupinmygums"));

        Console.WriteLine(FirstNonRepeatingChar("Hello"));
        Console.WriteLine(FirstNonRepeatingChar("Hhohh"));*/

        Console.WriteLine(AnagramCheck("aba", "baa").ToString());
        Console.WriteLine(AnagramCheck("aab", "baa").ToString());
        Console.WriteLine(AnagramCheck("aba", "").ToString());
        Console.WriteLine(AnagramCheck("ab", "baa").ToString());
        Console.WriteLine(AnagramCheck("asdfasdvzxcv", "baafba").ToString());
        Console.WriteLine(AnagramCheck("1", "2").ToString());
        //Console.WriteLine(AnagramCheck("aba", null).ToString());
    }
}