namespace Tasks.entities.@base
{
    /// <summary>
    /// Abstract class that generalizes the movement model of Entities
    /// </summary>
    public abstract class SimpleMovingEntity : SimpleEntity, IMovingEntity
    {
        private Vector2d _vel;

        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="type">The Entity's type</param>
        /// <param name="world">The game's world</param>
        protected SimpleMovingEntity(EntityType type, IWorld world) : base(type, world)
        {
            _vel = new Vector2d(0, 0);
        }

        /// <inheritdoc/>
        public Vector2d GetVel()
        {
            return _vel;
        }

        /// <inheritdoc/>
        public void SetVel(Vector2d vel)
        {
            _vel = vel;
        }
    }
}