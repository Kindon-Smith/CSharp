using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Text;

using HelloWorld.E4Lib;

namespace HelloWorld.Exercises;

public class Exercise4
{

    public static void Run()
    {

        Console.WriteLine($"Reversing 'catDog': {ReverseString.Execute("catDog")}");
        Console.WriteLine($"Reversing '': {ReverseString.Execute("")}");

        Console.WriteLine($"Finding max of: [ 1, 2, 3, 4, 5 ] {FindMax.Execute(new int[] { 1, 2, 3, 4, 5 })}");
        Console.WriteLine($"Finding max of: [ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 ] {FindMax.Execute(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })}");

        Console.WriteLine($"Counting vowels in 'looh': {CountVowels.Execute("Hello")}");
        Console.WriteLine($"Counting vowels in 'Potatosandwichupinmygums': {CountVowels.Execute("Potatosandwichupinmygums")}");

        Console.WriteLine($"Finding first non-repeating character in 'loohl': {FirstNonRepeatingChar.Execute("loohl")}");
        Console.WriteLine($"Finding first non-repeating character in 'Hhohh': {FirstNonRepeatingChar.Execute("Hhohh")}");

        Console.WriteLine($"Determining if 'aba' and 'baa' are anagrams: {AnagramCheck.Execute("aba", "baa")}");
        Console.WriteLine($"Determining if '' and 'baa' are anagrams: {AnagramCheck.Execute("", "baa")}");

        Console.WriteLine(LengthOfLongestSubstring.Execute($"Longest Substring of string: abcabcbb"));
        Console.WriteLine(LengthOfLongestSubstring.Execute($"Longest Substring of string: bbbbb"));
    }
}