namespace Tasks.Entities
{
    /// <summary>
    /// Dummy interface for representing a player.
    /// </summary>
    public interface IPlayer : IEntity
    {
        /// <summary>
        /// Player victory status.
        /// </summary>
        bool Win { get; set; }
    }
}