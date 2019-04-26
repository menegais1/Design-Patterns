using System;

namespace DesignPatterns
{
    public interface IMovementType
    {
        void Move();
    }

    public class WalkMovement : IMovementType
    {
        public void Move()
        {
            Console.Out.WriteLine("\tI'm Walking");
        }
    }

    public class FlyMovement : IMovementType
    {
        public void Move()
        {
            Console.Out.WriteLine("\tI'm Flying");
        }
    }

    public class NoMomevement : IMovementType
    {
        public void Move()
        {
            Console.Out.WriteLine("\tI'm Standing Still");
        }
    }
}