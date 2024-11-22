using System.Reflection.Emit;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an enemy with armor but default weapon (Fists)
            Enemy EnemyWithFists = new EnemyBuilder().SetArmor(20)
                                                     .GetInstance();
            // Print the current state of the enemy
            Console.WriteLine(EnemyWithFists);
            // Perform an attack with the default weapon (Fists)
            EnemyWithFists.Attack();

            // Create an enemy with a knife as the weapon and set HP
            Enemy EnemyWithKnife = new EnemyBuilder().SetWeapon(new Knife())
                                                     .SetHP(100)
                                                     .GetInstance();
            // Print the current state of the enemy with the knife
            Console.WriteLine(EnemyWithKnife);
            // Perform an attack with the knife weapon
            EnemyWithKnife.Attack();
        }
    }
}
