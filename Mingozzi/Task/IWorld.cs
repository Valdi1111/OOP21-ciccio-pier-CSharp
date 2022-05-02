using System.Collections.Generic;

namespace Task
{
    /// <summary>
    /// Contains game objects, like blocks, entities and player.
    /// </summary>
    public interface IWorld
    {
        /// <summary>
        /// Retrieves a list containing all the World's Entities
        /// </summary>
        /// <returns>The Entities list</returns>
        List<IEntity> GetEntities();

        /// <summary>
        /// Add an entity to this world
        /// </summary>
        /// <param name="entity">The Entity to add</param>
        void AddEntity(IEntity entity);
        
        /// <summary>
        /// Remove an entity from this world
        /// </summary>
        /// <param name="entity">The Entity</param>
        void RemoveEntity(IEntity entity);

        /// <summary>
        /// Get the Player
        /// </summary>
        /// <returns>The Player</returns>
        IPlayer GetPlayer();
    }
}