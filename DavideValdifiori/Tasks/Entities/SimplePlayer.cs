namespace Tasks.Entities
{
    /// <summary>
    /// Dummy class for representing a player implementation.
    /// </summary>
    public class SimplePlayer : SimpleEntity, IPlayer
    {
        /// <summary>
        /// Dummy constructor for this class.
        /// </summary>
        /// <param name="world">the world</param>
        public SimplePlayer(IWorld world) : base(world)
        {
            Win = false;
        }

        /// <inheritdoc/>
        public bool Win { get; set; }
    }
}