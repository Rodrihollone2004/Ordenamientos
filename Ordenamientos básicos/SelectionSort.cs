
using System.Diagnostics;

public class SelectionSort
{
    public int totalStepsSS;

    public void Start()
    {
        int[] finalArray;
        int[] firstArray = [5, 1, 4, 3, 2];
        int[] secondArray = [1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14];

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine("\n------ Selection Sort ------");
        finalArray = CompareSS(secondArray); //Change the array to compare

        stopwatch.Stop();

        string output = "";
        for (int i = 0; i < finalArray.Length; i++)
        {
            output += finalArray[i] + ", ";
        }
        Console.WriteLine($"\nFinal array: {output}");

        long elapsedTicks = stopwatch.ElapsedTicks;
        Console.WriteLine($"\nElapsed time: {elapsedTicks} ticks");
    }

    private int[] CompareSS(int[] array)
    {
        int steps = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = GetIndexOfMinValue(array, i);
            if (array[i] > array[minIndex])
            {
                int number = array[i];
                array[i] = array[minIndex];
                array[minIndex] = number;
                steps++;

                string output = "";
                for (int x = 0; x < array.Length; x++)
                {
                    output += array[x] + ", ";
                }
                Console.WriteLine($"Step {steps}: {output}");
            }
        }

        totalStepsSS = steps;
        return array;
    }

    private int GetIndexOfMinValue(int[] array, int startIndex)
    {
        int outputIndex = startIndex;

        for (int i = startIndex + 1; i < array.Length; i++)
            if (array[i] < array[outputIndex])
                outputIndex = i;

        return outputIndex;
    }
}

