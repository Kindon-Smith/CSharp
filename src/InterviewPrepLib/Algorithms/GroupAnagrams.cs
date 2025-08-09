using System.Text.RegularExpressions;

namespace InterviewPrepLib.Algorithms;

public static class GroupAnagrams
{
    /// <summary>
    /// Group anagrams from a given list of strings. Uses built in C# Array.Sort() and dictionary mapping
    /// Time Complexity: O(n * k log k), where N is the number of strings, k log k is the time to sort each string.
    /// Space Complexity: O(n * k), where n is the number of strings (used as keys) and k is the length of each key.
    /// </summary>
    /// <param name="anagrams"> List<string> of words to categorize into anagram lists</param>
    /// <returns> A list of lists of anagrams </returns>
    public static List<List<string>> Execute(List<string> anagrams)
    {
        #region Input Validation
        if (anagrams is null)
        {
            throw new ArgumentNullException(nameof(anagrams), "Input list cannot be null.");
        }
        if (anagrams.Count == 1)
        {
            return new List<List<string>> { new List<string> { anagrams[0] } };
        }
        #endregion

        char[] chars;
        Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();
        foreach (var currAnagram in anagrams)
        {
            chars = currAnagram.ToCharArray();
            Array.Sort(chars);
            var mapKey = new string(chars);
            if (!anagramMap.ContainsKey(mapKey))
            {
                anagramMap[mapKey] = new List<string>();
            }
            anagramMap[mapKey].Add(currAnagram);


        }
        return anagramMap.Values.ToList();

    }
}