namespace Builder
{
    // Represents a "Knife" weapon
    public class Knife : Weapon
    {
        public override float damage { get; set; } = 30;
        public override string name { get; set; } = "Knife";
        public override void Attack()
        {
            Console.WriteLine($"You were stabbed by knife: -{damage}");
        }
    }
}
