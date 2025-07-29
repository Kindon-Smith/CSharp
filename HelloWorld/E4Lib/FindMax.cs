namespace HelloWorld.E4Lib;

public static class FindMax
{
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