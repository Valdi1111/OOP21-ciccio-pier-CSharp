namespace Tasks.Blocks
{
    /// <summary>
    /// Represents a block in the <see cref="IWorld"/>.
    /// </summary>
    public interface IBlock : IGameObject
    {
        /// <summary>
        /// Constant representing the size of the block.
        /// </summary>
        public const int Size = 32;

        /// <summary>
        /// Type of the block.
        /// </summary>
        BlockType Type { get; set; }

        /// <summary>
        /// Check if this type of block is solid or not.
        /// </summary>
        /// <returns>true if solid, false otherwise</returns>
        bool IsSolid => Type.IsSolid();

        /// <summary>
        /// Check if this type of block can be interacted with
        /// </summary>
        /// <returns>true if you can interact with it, false otherwise</returns>
        bool CanInteract => Type.CanInteract();
    }
}