namespace Tasks.entities.@base
{
    /// <summary>
    /// Represents a type of Entity with its details
    /// </summary>
    public class EntityType
    {
        /// <summary>
        /// Represents the Player
        /// </summary>
        public static readonly EntityType Player = new EntityType(32, 64, 1000, 60);

        public static readonly EntityType Missile = new EntityType(10, 10, 0, 80);

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
        public int Width => _width;

        /// <summary>
        /// Returns the Entity height
        /// </summary>
        public int Height => _height;

        /// <summary>
        /// Returns the Entity total hp
        /// </summary>
        public int MaxHp => _maxHp;

        /// <summary>
        /// Returns the Entity attack damage
        /// </summary>
        public int AttackDamage => _attackDamage;
    }
}