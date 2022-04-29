using System.Collections.Generic;
using Tasks.Blocks;
using Tasks.Entities;

namespace Tasks
{
    /// <summary>
    /// Contains game objects, like blocks, entities and player.
    /// </summary>
    public interface IWorld : IEnumerable<IBlock>
    {
        /// <summary>
        /// The factory for creating <see cref="IEntity"/> instances.
        /// </summary>
        IEntityFactory EntityFactory { get; }

        /// <summary>
        /// The factory for creating <see cref="IBlock"/> instances.
        /// </summary>
        IBlockFactory BlockFactory { get; }

        /// <summary>
        /// The world's height in blocks.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// The world's width in blocks.
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Get the block at the specific coordinates.
        /// </summary>
        /// <param name="x">pos x</param>
        /// <param name="y">pos y</param>
        /// <returns>the block</returns>
        IBlock? GetBlock(int x, int y);

        /// <summary>
        /// Set the block at the specific coordinates.
        /// </summary>
        /// <param name="x">pos x</param>
        /// <param name="y">pos y</param>
        /// <param name="block">the new block</param>
        void SetBlock(int x, int y, IBlock block);

        /// <summary>
        /// Get a list containing the entities of this world.
        /// </summary>
        /// <returns>the list</returns>
        List<IEntity> GetEntities();

        /// <summary>
        /// Get a list containing the entities in a certain range.
        /// </summary>
        /// <param name="pos">the starting position</param>
        /// <param name="radius">the radius</param>
        /// <returns>the list</returns>
        List<IEntity> GetEntitiesInRange(Vector2d pos, int radius);

        /// <summary>
        /// Add an entity to this world.
        /// </summary>
        /// <param name="entity">the entity</param>
        void AddEntity(IEntity entity);

        /// <summary>
        /// Remove an entity from this world.
        /// </summary>
        /// <param name="entity">the entity</param>
        void RemoveEntity(IEntity entity);

        /// <summary>
        /// The player.
        /// </summary>
        IPlayer? Player { get; }

        /// <summary>
        /// Reset the world.
        /// </summary>
        void Clear();
    }
}