namespace Tasks.Blocks
{
    /// <summary>
    /// Simple implementation of the interface <see cref="IBlock"/>.
    /// </summary>
    public class SimpleBlock : SimpleGameObject, IBlock
    {
        /// <summary>
        /// Constructor for this class, it instantiates a block with the specific <see cref="BlockType"/>.
        /// </summary>
        /// <param name="type">block type</param>
        public SimpleBlock(BlockType type)
        {
            Type = type;
        }

        /// <summary>
        /// Width of the block.
        /// </summary>
        public override int Width => IBlock.Size;

        /// <summary>
        /// Height of the block.
        /// </summary>
        public override int Height => IBlock.Size;

        /// <inheritdoc/>
        public BlockType Type { get; set; }
    }
}