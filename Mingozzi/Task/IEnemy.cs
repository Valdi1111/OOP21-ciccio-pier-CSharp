namespace Task
{
    /// <summary>
    /// Represents a generic Enemy
    /// </summary>
    public interface IEnemy : ILivingEntity
    {
        /// <summary>
        /// Get the Entity attack damage
        /// </summary>
        /// <returns>The damage amount</returns>
        int GetAttackDamage();

        /// <summary>
        /// Attacks the Player
        /// </summary>
        void AttackPlayer();
    }
}