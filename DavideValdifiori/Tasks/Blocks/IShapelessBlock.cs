using Tasks.Entities;

namespace Tasks.Blocks
{
    /// <summary>
    /// Represents a block in the <see cref="IWorld"/>.
    /// </summary>
    public interface IShapelessBlock : IBlock
    {
        /// <summary>
        /// Function executed when an entity go through this block.
        /// </summary>
        /// <param name="entity">the entity</param>
        void OnCollision(IEntity entity);
    }
}