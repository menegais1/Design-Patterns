using System;

namespace DesignPatterns
{
    public class Enemy
    {
        protected string name;
        protected int life;

        protected IMovementType movementType;

        public Enemy(string name, int life, IMovementType movementType)
        {
            this.name = name;
            this.life = life;
            this.movementType = movementType;
        }

        public void Move()
        {
            this.WriteName();
            this.movementType.Move();
        }

        public void WriteName()
        {
            Console.Out.WriteLine("I'm " + this.name);
        }

        public void SetMovementType(IMovementType movementType)
        {
            this.movementType = movementType;
        }
    }
}