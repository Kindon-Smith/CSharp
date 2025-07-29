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
            throw new ArgumentNullException("Input array cannot be null.");
        }
        if (numbers.Length == 0)
        {
            throw new ArgumentNullException("Input array cannot be empty.");
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
            throw new ArgumentNullException("Input string cannot be null.");
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

    public static void Run()
    {
        string catDog = "catDog";
        var reversedCatDog = ReverseString(catDog);
        Console.WriteLine(reversedCatDog);
        Console.WriteLine(ReverseString(""));
        Console.WriteLine(ReverseString("1"));
    }
}