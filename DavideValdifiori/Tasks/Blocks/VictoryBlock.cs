using Tasks.Entities;

namespace Tasks.Blocks
{
    /// <summary>
    /// Simple implementation of the interface <see cref="IShapelessBlock"/> that let you win the game when go through it.
    /// </summary>
    public class VictoryBlock : SimpleBlock, IShapelessBlock
    {
        /// <summary>
        /// Constructor for this class, it instantiates a block with the specific <see cref="BlockType"/>.
        /// </summary>
        /// <param name="type">block type</param>
        public VictoryBlock(BlockType type) : base(type)
        {
        }

        /// <inheritdoc/>>
        public void OnCollision(IEntity entity)
        {
            if (entity is IPlayer player)
            {
                player.Win = true;
            }
        }
    }
}