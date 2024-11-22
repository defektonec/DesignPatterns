using System;

namespace Builder
{
    // Interface for the EnemyBuilder to provide methods for configuring an enemy
    public interface IEnemyBuilder
    {
        public IEnemyBuilder SetHP(float hp);

        public IEnemyBuilder SetArmor(float armor);

        public IEnemyBuilder SetWeapon(Weapon weapon);

        public Enemy GetInstance();
    }
}
