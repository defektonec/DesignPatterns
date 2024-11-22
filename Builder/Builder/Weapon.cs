namespace Builder
{
    // Abstract base class representing a weapon
    public abstract class Weapon
    {
        public abstract float damage { get; set; }

        public abstract string name { get; set; }

        public abstract void Attack();
    }
}
