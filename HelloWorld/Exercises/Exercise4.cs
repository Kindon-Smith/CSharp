namespace HelloWorld.Exercises;

public class Exercise4
{
    public static int FindMax(int[] numbers)
    {
        /// <summary>
        /// Checks if input is null and throws error
        /// Checks if input is of Length 1 and returns the only value
        /// </summary>
        if (numbers is null)
        {
            throw new ArgumentException("Input is not valid. Please provide an array of integers.");
        }
        if (numbers.Length == 1)
        {
            return numbers[0];
        }

        int maximumValue = int.MinValue;
        foreach (int number in numbers)
        {
            maximumValue = number > maximumValue ? number : maximumValue;
        }
        return maximumValue;
    }
}