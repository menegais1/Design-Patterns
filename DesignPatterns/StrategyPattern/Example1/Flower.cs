namespace DesignPatterns
{
    public class Flower : Enemy
    {
        public Flower(string name, int life, IMovementType movementType) : base(name, life, movementType)
        {
        }
    }
}