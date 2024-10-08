﻿
using System.Diagnostics;

public class BubbleSort
{
    public int totalStepsBS;

    public void Start()
    {
        int[] finalArray;
        int[] firstArray = [5, 1, 4, 3, 2];
        int[] secondArray = [1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14];

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine("------ Bubble Sort ------");
        finalArray = CompareBS(secondArray); //Change the array to compare

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

