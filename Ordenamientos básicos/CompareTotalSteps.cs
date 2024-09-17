
public class CompareTotalSteps
{
    public void CompareSteps(BubbleSort bubbleSort, SelectionSort selectionSort)
    {
        Console.WriteLine("\n------ Compare number of steps ------");

        if (selectionSort.totalStepsSS <= bubbleSort.totalStepsBS)
            Console.WriteLine($"\nSelection sort had fewer steps, with {selectionSort.totalStepsSS}");
        else
            Console.WriteLine($"\nBubble sort had fewer steps, with {bubbleSort.totalStepsBS}");
    }
}

