using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Text;

using HelloWorld.E4Lib;

namespace HelloWorld.Exercises;

public class Exercise4
{

    public static void Run()
    {
        Console.WriteLine("Running Exercise 4...");
        Console.WriteLine($"{nameof(ReverseString)}: {ReverseString.Execute("catDog")}");
        Console.WriteLine($"{nameof(ReverseString)} '': {ReverseString.Execute("")}");

        Console.WriteLine($"{nameof(FindMax)}: [ 1, 2, 3, 4, 5 ] {FindMax.Execute(new int[] { 1, 2, 3, 4, 5 })}");
        Console.WriteLine($"{nameof(FindMax)}: [ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 ] {FindMax.Execute(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })}");

        Console.WriteLine($"{nameof(CountVowels)}: 'looh': {CountVowels.Execute("Hello")}");
        Console.WriteLine($"{nameof(CountVowels)}: 'Potatosandwichupinmygums': {CountVowels.Execute("Potatosandwichupinmygums")}");

        Console.WriteLine($"{nameof(FirstNonRepeatingChar)}: Finding first non-repeating character in 'loohl': {FirstNonRepeatingChar.Execute("loohl")}");
        Console.WriteLine($"{nameof(FirstNonRepeatingChar)}: Finding first non-repeating character in 'Hhohh': {FirstNonRepeatingChar.Execute("Hhohh")}");

        Console.WriteLine($"{nameof(AnagramCheck)}: Determining if 'aba' and 'baa' are anagrams: {AnagramCheck.Execute("aba", "baa")}");
        Console.WriteLine($"{nameof(AnagramCheck)}: Determining if '' and 'baa' are anagrams: {AnagramCheck.Execute("", "baa")}");

        Console.WriteLine($"{nameof(LengthOfLongestSubstring)}: Longest Substring of string: abcabcbb: {LengthOfLongestSubstring.Execute("abcabcbb")}");
        Console.WriteLine($"{nameof(LengthOfLongestSubstring)}: Longest Substring of string: bbabcb: {LengthOfLongestSubstring.Execute("bbcb")}");

        Console.WriteLine($"{nameof(RemoveDuplicates)}: Removing duplicates from array: [ 1, 2, 2, 3, 4, 4, 5 ]");
        int[] numbers = new int[] { 1, 2, 2, 3, 4, 4, 5 };
        RemoveDuplicates.Execute(numbers); 
        Console.WriteLine($"{nameof(RemoveDuplicates)}: Result: [ {string.Join(", ", numbers)} ]");
    }
}