using System;

namespace DesignPatterns.Example2
{
    public interface ISortingType
    {
        void Sort(int[] array);
    }

    public class BubbleSort : ISortingType
    {
        public void Sort(int[] array)
        {
            Console.Out.WriteLine("Bubble Sort");
            bool change = true;
            int passes = 1;
            while (change)
            {
                change = false;
                for (int i = 0; i < array.Length - passes; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        change = true;
                    }
                }

                passes++;
            }
        }
    }

    public class SelectionSort : ISortingType
    {
        public void Sort(int[] array)
        {
            Console.Out.WriteLine("Selection Sort");
            int min;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                if (array[i] != array[min])
                {
                    int temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }
    }

    public class InsertionSort : ISortingType
    {
        public void Sort(int[] array)
        {
            Console.Out.WriteLine("Insertion Sort");
            int key;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }
    }
}