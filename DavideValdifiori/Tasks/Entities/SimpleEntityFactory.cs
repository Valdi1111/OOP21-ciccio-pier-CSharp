namespace Tasks.Entities
{
    /// <summary>
    /// Simple implementation of the interface <see cref="IEntityFactory"/>.
    /// </summary>
    public class SimpleEntityFactory : IEntityFactory
    {
        private readonly IWorld _world;

        /// <summary>
        /// Constructor for this class.
        /// </summary>
        /// <param name="world">the world</param>
        public SimpleEntityFactory(IWorld world)
        {
            _world = world;
        }

        /// <inheritdoc/>
        public IPlayer CreatePlayer()
        {
            return new SimplePlayer(_world);
        }

        /// <inheritdoc/>
        public IEntity? CreateEntity(EntityType type)
        {
            if (type == EntityType.Player)
            {
                return CreatePlayer();
            }
            else if (type == EntityType.Coin)
            {
                // Create coin
            }
            // etc..

            return null;
        }
    }
}