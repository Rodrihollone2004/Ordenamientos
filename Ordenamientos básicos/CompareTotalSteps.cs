
public class CompareTotalSteps
{
    public void CompareSteps(BubbleSort bubbleSort, SelectionSort selectionSort)
    {
        if (selectionSort.totalStepsSS <= bubbleSort.totalStepsBS)
            Console.WriteLine($"\nSelection Sort tuvo menor cantidad de pasos, con {selectionSort.totalStepsSS}");
        else
            Console.WriteLine($"\nBubble Sort tuvo menor cantidad de pasos, con {bubbleSort.totalStepsBS}");
    }
}

