namespace Builder
{
    // Represents a basic weapon, "Fists"
    public class Fists : Weapon
    {
        public override float damage { get; set; } = 10;
        public override string name { get; set; } = "Fists";   
        public override void Attack()
        {
            Console.WriteLine($"You are punched by fists: -{damage} ");
        }
    }
}
