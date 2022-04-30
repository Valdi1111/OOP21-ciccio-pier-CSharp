namespace Task
{
    /// <summary>
    /// Represents a type of Entity with its details
    /// </summary>
    public class EntityType
    {
        /// <summary>
        /// Represents the Player
        /// </summary>
        public static readonly EntityType Player = new EntityType(32,64,1000,60);
        /// <summary>
        /// Represents a ShootingPea
        /// </summary>
        public static readonly EntityType ShootingPea = new EntityType(32,64,130,100);
        
        private readonly int _width;
        private readonly int _height;
        private readonly int _maxHp;
        private readonly int _attackDamage;

        /// <summary>
        /// Entity's types constructor
        /// </summary>
        /// <param name="width">The Entity's width</param>
        /// <param name="height">The Entity's height</param>
        /// <param name="maxHp">The Entity's total hp</param>
        /// <param name="attackDamage">The Entity's attack damage</param>
        private EntityType(int width, int height, int maxHp, int attackDamage)
        {
            _width = width;
            _height = height;
            _maxHp = maxHp;
            _attackDamage = attackDamage;
        }

        /// <summary>
        /// Returns the Entity width
        /// </summary>
        /// <returns>Entity's width</returns>
        public int GetWidth() {
            return _width;
        }
        
        /// <summary>
        /// Returns the Entity height
        /// </summary>
        /// <returns>Entity's height</returns>
        public int GetHeight() {
            return _height;
        }
        
        /// <summary>
        /// Returns the Entity total hp
        /// </summary>
        /// <returns>Entity's maximum hp</returns>
        public int GetMaxHp() {
            return _maxHp;
        }

        /// <summary>
        /// Returns the Entity attack damage
        /// </summary>
        /// <returns>Entity's damage</returns>
        public int GetAttackDamage() {
            return _attackDamage;
        }
    }
}