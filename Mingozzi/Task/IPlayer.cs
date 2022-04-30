namespace Task
{
    /// <summary>
    /// Represents a playable Entity
    /// </summary>
    public interface IPlayer : ILivingEntity
    {
        /// <summary>
        /// Get the attack range of the player
        /// </summary>
        /// <returns>The range of attack</returns>
        int GetAttackRange();

        /// <summary>
        /// The player attacks, prioritizing the nearest enemy
        /// </summary>
        void AttackNearest();
    }
}