namespace HelloWorld.Exercises;

using HelloWorld.E2Lib;
using HelloWorld.E3Lib;
using HelloWorld.E4Lib;

public class Exercise5
{
    /// <summary>
    /// This exercise is a dive into LINQ usage
    /// 
    /// </summary>

    public static void Run()
    {
        var words = new List<string> { "cat", "window", "door", "hat", "elephant" };
        #region Words
        var longWords = words.Where(n => n.Length > 3).ToList();
        Console.WriteLine(string.Join(", ", longWords));

        var orderedWords = words.OrderBy(n => n).ToList();
        Console.WriteLine(string.Join(", ", orderedWords));

        var sortedFirstLettersOfWords = words
            .Select(word => word[0])
            .OrderBy(letter => letter)
            .ToList();
        Console.WriteLine(string.Join(", ", sortedFirstLettersOfWords));


        // idiomatic to use 'a' instead of "a" - single quotes declare a char, double declare a a string
        // minor performance benefits to using char over string for single character lookup
        // also more readable and understandable. 
        var countOfWordsWithA = words.Where(n => n.Contains('a')).Count();
        Console.WriteLine($"Words with a: {countOfWordsWithA}");
        #endregion

        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        #region Numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine(String.Join(", ", evenNumbers));

        var squaredNumbers = numbers.Select(n => n * n).ToList();
        Console.WriteLine(String.Join(", ", squaredNumbers));

        var summedNumbersAboveFive = numbers
                        .Where(n => n > 5)
                        .Sum();
        Console.WriteLine($"Sum of numbers larger than 5: {summedNumbersAboveFive}");
        #endregion


        /*var arrays = new List<int[]> { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };


        var twoLetterWords = words.Where(n => CountVowels.Execute(n) == 2);
        Console.WriteLine(string.Join(", ", twoLetterWords));

        var reversedStartsWithA = words
            .Select(word => ReverseString.Execute(word))
            .Where(reversedWord => reversedWord.StartsWith('a'))
            .ToList();
        Console.WriteLine(string.Join(", ", reversedStartsWithA));


        var maxValue = FindMax.Execute(arrays.Select(arr => FindMax.Execute(arr)).ToArray());
        Console.WriteLine(maxValue);*/
    }
    
}