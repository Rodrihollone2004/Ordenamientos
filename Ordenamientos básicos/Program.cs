
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

public class BubbleSort
{
    public int totalStepsBS;
    public void Start()
    {
        int[] finalArray;
        int[] firstArray = [5, 1, 4, 3, 2];
        int[] secondArray = [1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14];

        Console.WriteLine("------ Bubble Sort ------");
        finalArray = CompareBS(firstArray); //Se cambia el array el cual se quiere comparar pasandolo como parámetro de la función

        string output = "";
        for (int i = 0; i < finalArray.Length; i++)
        {
            output += finalArray[i] + ", ";
        }
        Console.WriteLine($"\nFinal array: {output}");
    }

    private int[] CompareBS(int[] array)
    {
        int steps = 0;
        int contadorOrdenado = 0;
        int index = 0;
        do
        {
            for (int i = 0; i < array.Length - 1 - contadorOrdenado; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int number = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = number;
                    index++;
                    steps++;

                    string output = "";
                    for (int j = 0; j < array.Length; j++)
                    {
                        output += array[j] + ", ";
                    }
                    Console.WriteLine($"Step {steps}: {output}");
                }
                else
                {
                    index++;
                }

            }

            contadorOrdenado++;
        } while (contadorOrdenado < array.Length - 1);

        totalStepsBS = steps;

        return array;
    }
}

public class SelectionSort
{
    public int totalStepsSS;

    public void Start()
    {
        int[] finalArray;
        int[] firstArray = [5, 1, 4, 3, 2];
        int[] secondArray = [1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14];

        Console.WriteLine("\n------ Selection Sort ------");
        finalArray = CompareSS(secondArray); //Se cambia el array el cual se quiere comparar pasandolo como parámetro de la función

        string output = "";
        for (int i = 0; i < finalArray.Length; i++)
        {
            output += finalArray[i] + ", ";
        }
        Console.WriteLine($"\nFinal array: {output}");
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

