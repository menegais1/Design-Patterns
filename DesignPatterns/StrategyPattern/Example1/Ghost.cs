namespace DesignPatterns
{
    public class Ghost : Enemy
    {
        public Ghost(string name, int life, IMovementType movementType) : base(name, life, movementType)
        {
        }
    }
}