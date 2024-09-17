
internal class Program
{
    static void Main(string[] args)
    {
        // ----------  Bubble Sort ----------
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Start();

        // ----------  Selection Sort ----------
        SelectionSort selectionSort = new SelectionSort();
        selectionSort.Start();

        //Compare Steps
        CompareTotalSteps total = new CompareTotalSteps();
        total.CompareSteps(bubbleSort, selectionSort);
    }
}