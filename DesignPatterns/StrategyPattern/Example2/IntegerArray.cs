using System;

namespace DesignPatterns.Example2
{
    public class IntegerArray
    {
        public int[] array;

        public IntegerArray(int[] array)
        {
            this.array = array;
        }

        public void Sort(ISortingType sortingType)
        {
            sortingType.Sort(this.array);
        }

        public void Print()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                Console.Out.Write(i + " ");
            }

            Console.Out.WriteLine();
        }
    }
}