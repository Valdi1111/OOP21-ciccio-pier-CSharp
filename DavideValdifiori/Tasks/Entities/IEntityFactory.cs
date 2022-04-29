namespace Tasks.Entities
{
    /// <summary>
    /// Contains methods used for creating <see cref="IEntity"/> instances.
    /// </summary>
    public interface IEntityFactory
    {
        /// <summary>
        /// Create the player.
        /// </summary>
        /// <returns>the created player</returns>
        IPlayer CreatePlayer();

        /// <summary>
        /// Create an entity and add it to the game world.
        /// </summary>
        /// <param name="type">the entity type</param>
        /// <returns>the created entity</returns>
        IEntity? CreateEntity(EntityType type);
    }
}