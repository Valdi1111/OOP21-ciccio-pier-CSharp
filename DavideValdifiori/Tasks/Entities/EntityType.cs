namespace Tasks.Entities
{
    /// <summary>
    /// Dummy interface for representing a entity type.
    /// </summary>
    public class EntityType
    {
        /// <summary>
        /// Represents the Player.
        /// </summary>
        public static readonly EntityType Player = new EntityType();

        /// <summary>
        /// Represents a coin.
        /// </summary>
        public static readonly EntityType Coin = new EntityType();

        /// <summary>
        /// Represents a CryingPotato.
        /// </summary>
        public static readonly EntityType CryingOnion = new EntityType();
    }
}