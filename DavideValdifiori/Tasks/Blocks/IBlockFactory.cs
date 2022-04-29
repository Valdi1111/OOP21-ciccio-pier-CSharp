namespace Tasks.Blocks
{
    /// <summary>
    /// Contains methods used for creating <see cref="IBlock"/> instances.
    /// </summary>
    public interface IBlockFactory
    {
        /// <summary>
        /// Create a block and add it to the game world.
        /// </summary>
        /// <param name="type">the block type</param>
        /// <returns>the created block</returns>
        IBlock? CreateBlock(BlockType type);
    }
}