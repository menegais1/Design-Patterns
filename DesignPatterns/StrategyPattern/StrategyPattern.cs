using System;
using DesignPatterns.Example2;

namespace DesignPatterns
{
    public static class StrategyPattern
    {
        public static void RunExample1()
        {
            Enemy enemy1 = new Gumba("Gumba", 100, new WalkMovement());
            Enemy enemy2 = new Flower("Flower", 100, new NoMomevement());
            Enemy enemy3 = new Ghost("Ghost", 100, new FlyMovement());

            enemy1.Move();
            enemy2.Move();
            enemy3.Move();

            Console.Out.WriteLine("Gumba lost it's ability to walk");
            enemy1.SetMovementType(new NoMomevement());

            enemy1.Move();
            enemy2.Move();
            enemy3.Move();
        }

        public static void RunExample2()
        {
            IntegerArray array1 = new IntegerArray(new[] {9, 12, -1, 4, 7, 2, 1, 0});
            IntegerArray array2 = new IntegerArray(new[] {9, 12, -1, 4, 7, 2, 1, 0});
            IntegerArray array3 = new IntegerArray(new[] {9, 12, -1, 4, 7, 2, 1, 0});
            array1.Sort(new BubbleSort());
            array1.Print();
            array2.Sort(new InsertionSort());
            array2.Print();
            array3.Sort(new SelectionSort());
            array3.Print();
        }
    }
}