namespace Tasks.Entities
{
    /// <summary>
    /// Dummy interface for representing a player implementation.
    /// </summary>
    public class SimplePlayer : IPlayer
    {
        /// <summary>
        /// Dummy constructor for this class.
        /// </summary>
        /// <param name="world">the world</param>
        public SimplePlayer(IWorld world)
        {
            Win = false;
        }

        /// <inheritdoc/>
        public bool Win { get; set; }
    }
}