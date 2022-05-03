namespace Tasks.entities.@base
{
    public interface IEntity : IGameObject
    {
        /// <summary>
        /// Returns the type of the Entity
        /// </summary>
        /// <returns>Entity's type</returns>
        EntityType GetType();

        /// <summary>
        /// Called every game cycle to update the Entity
        /// </summary>
        /// <param name="ticks">game ticks</param>
        void Tick(long ticks);
    }
}