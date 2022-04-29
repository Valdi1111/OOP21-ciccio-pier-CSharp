namespace Tasks.Blocks
{
    /// <summary>
    /// Simple implementation of the interface <see cref="IBlockFactory"/>.
    /// </summary>
    public class SimpleBlockFactory : IBlockFactory
    {
        /// <inheritdoc/>
        public IBlock? CreateBlock(BlockType type)
        {
            if (type == BlockType.MausoleumTopLeft || type == BlockType.MausoleumTopRight ||
                type == BlockType.MausoleumBottomLeft || type == BlockType.MausoleumBottomRight ||
                type == BlockType.Portal)
            {
                return new VictoryBlock(type);
            }

            return new SimpleBlock(type);
        }
    }
}