

using System.Globalization;

namespace InterviewPrepLib.Algorithms;


public static class RemoveDuplicates
{   
    /// <summary>
    /// Removes duplicates from a sorted array of integers in place.
    /// The method modifies the input array to contain only unique elements at the beginning.
    /// The remaining elements in the array are not guaranteed to be in any specific order.
    /// The method does not return a new array, but modifies the original array.
    /// Time Complexity: O(n), where n is the length of the input array.
    /// Space Complexity: O(1), as it uses a constant amount of extra space.
    /// </summary>
    /// <param name="numbers">The sorted array to remove duplicates from.</param>
    /// <returns>void</returns>
    /// <exception cref="ArgumentNullException">Thrown when numbers is null</exception>
    public static void Execute(int[] numbers)
    {
        if (numbers is null)
        {
            throw new ArgumentNullException(nameof(numbers), "Input array cannot be null.");
        }
        if (numbers.Length == 0 || numbers.Length == 1)
        {
            return;
        }

        int writeIndex = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1])
            {
                numbers[writeIndex] = numbers[i];
                writeIndex++;
            }
        }
        return;
    }
}
    