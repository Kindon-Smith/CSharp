namespace InterviewPrepLib.Algorithms;

public static class FindMax
{
    /// <summary>
    /// Finds the maximum value of a non-empty array of integers.
    /// The method iterates through the array, comparing each element to find the maximum.
    /// Time Complexity: O(n), where n is the length of the input array.
    /// Space Complexity: O(1), as it uses a constant amount of extra space.
    /// </summary>
    /// <param name="numbers">The array of integers to search.</param>
    /// <returns>The maximum integer value found in the array.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    /// <exception cref="ArgumentException">Thrown when input is empty.</exception>
    public static int Execute(int[] numbers)
    {
        if (numbers is null)
            throw new ArgumentNullException(nameof(numbers), "Input array cannot be null.");
        if (numbers.Length == 0)
            throw new ArgumentException("Input array cannot be empty.", nameof(numbers));
        if (numbers.Length == 1)
            return numbers[0];

        int maxValue = int.MinValue;
        foreach (int number in numbers)
            maxValue = number > maxValue ? number : maxValue;
        return maxValue;
    }
}