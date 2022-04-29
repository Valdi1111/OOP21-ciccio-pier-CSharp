namespace Task
{
    public interface IEntity : IGameObject
    {
        /// <summary>
        /// Returns the type of the Entity
        /// </summary>
        /// <returns>Entity's type</returns>
        EntityType GetEntityType();
        
        /// <summary>
        /// Load the Entity
        /// </summary>
        void Load();

        /// <summary>
        /// Checks if Entity was removed
        /// </summary>
        /// <returns> If removed </returns>
        bool IsRemoved();

        bool CheckCollision(IGameObject obj);
        
        /// <summary>
        /// Removes the Entity from the World
        /// </summary>
        void Remove();

        /// <summary>
        /// Called every game cycle to update the Entity
        /// </summary>
        /// <param name="ticks"> The GameEngine ticks</param>
        void Tick(long ticks);
    }
    
}