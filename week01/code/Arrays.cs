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

    /* PLAN:
    // 1. Create a new array that can store the required number of multiples.
    // 2. Use a loop to go through each position in the array.
    // 3. For each index:
       - Multiply the starting number by the current multiple number.
       - Since array indexes start at 0, use (index + 1).
    4. Store the calculated multiple into the array.
    5. After the loop finishes, return the completed array.*/

  
    // Create the array
    double[] result = new double[length];

    // Fill the array with multiples
    for (int i = 0; i < length; i++)
    {
        result[i] = number * (i + 1);
    }

    // Return the completed array
    return result;
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

       // PLAN:
      // 1. Determine where the split point should be.
       // - The last "amount" values will move to the front.
       //- The remaining values will move to the back.

    //2. Find the split index by subtracting amount from data.Count.

    //3. Create two temporary lists:
    // - First part = values before the split index.
    //- Second part = values from the split index to the end.

    //4. Clear the original list.

    //5. Add the second part first because these values rotate to the front.

   // 6. Add the first part after it.

    // 7. The list is now rotated correctly.


    // Find where to split the list
    int splitIndex = data.Count - amount;

    // Get the first section of the list
    List<int> firstPart = data.GetRange(0, splitIndex);

    // Get the section that moves to the front
    List<int> secondPart = data.GetRange(splitIndex, amount);

    // Clear the original list
    data.Clear();

    // Add rotated values back in order
    data.AddRange(secondPart);
    data.AddRange(firstPart);
    }
}
