using System;

namespace Builder
{
    internal class EnemyBuilder : IEnemyBuilder
    {
        // Private instance of the Enemy that is being built
        private Enemy _enemyInstance = new Enemy();

        // Set the armor for the enemy and return the builder for chaining
        public IEnemyBuilder SetArmor(float armor)
        {
            _enemyInstance.armor = armor;
            return this;
        }

        // Set the health for the enemy and return the builder for chaining
        public IEnemyBuilder SetHP(float hp)
        {
            _enemyInstance.health = hp;
            return this;
        }

        // Set the weapon for the enemy and return the builder for chaining
        public IEnemyBuilder SetWeapon(Weapon weapon)
        {
            _enemyInstance.weapon = weapon;
            return this;
        }

        // Return the final built enemy instance
        public Enemy GetInstance() => _enemyInstance;
    }
}
