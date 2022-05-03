namespace Tasks.entities.@base
{
    public interface IWorld
    {
        /// <summary>
        /// Get the player.
        /// </summary>
        /// <returns>the player</returns>
        IPlayer Player();

        /// <summary>
        /// Reset the world.
        /// </summary>
        void Clear();
    }
}