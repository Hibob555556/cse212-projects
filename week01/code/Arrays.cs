public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Allocate double[] with length of count
        double[] multiples = new double[length];

        // 2. Compute each multiple with a loop
        for (int i = 0; i <= length - 1; i++)
        {
            // 3. Position i will store (start * (i + 1))
            double multiple = number * (i + 1);
            multiples[i] = multiple;
        }

        // 4. Return filled double[] array

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Determine split index via data.Count - amount
        int splitIndex = data.Count - amount;

        // 2. Extract right of the list which will be moved to the front
        List<int> rightSlice = data.TakeLast(amount).ToList();

        // 3. Extract left of the list which should be remaining values
        List<int> leftSlice = data.Take(splitIndex).ToList();

        // 4. Clear the original list data
        data.Clear();

        // 5. Add the section to the right of the split to back to the data list
        data.AddRange(rightSlice);

        // 6. Add the section to the left of the split back to the data list
        data.AddRange(leftSlice);

        // 7. Data modification finished
    }
}
