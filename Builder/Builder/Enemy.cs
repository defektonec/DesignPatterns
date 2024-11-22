using System.Collections.Generic;

namespace Builder
{
    public class Enemy
    {
        // Properties for health, armor, and weapon
        public float health { get; set; } = 50;
        public float armor { get; set; } = 0;
        public Weapon weapon { get; set; } = new Fists();
        public override string ToString() => $"Health: {health}│Armor: {armor}│Weapon: {weapon.name}";
        public void Attack() => weapon.Attack();
    }
}
