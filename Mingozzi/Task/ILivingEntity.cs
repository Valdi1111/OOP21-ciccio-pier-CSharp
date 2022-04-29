namespace Task
{
    public interface ILivingEntity : IMovingEntity
    {
        /// <summary>
        /// Returns the Entity's hp
        /// </summary>
        /// <returns>The Entity hp</returns>
        int GetHp();

        /// <summary>
        /// Returns the Entity maximum hp
        /// </summary>
        /// <returns>Entity maximum hp</returns>
        int GetMaxHp();

        /// <summary>
        /// Deals damage to the Entity
        /// </summary>
        /// <param name="amount">The amount of damage</param>
        void Damage(int amount);
        
        /// <summary>
        /// Heals the Entity
        /// </summary>
        /// <param name="amount">The amount of heal</param>
        void Heal(int amount);
        
        /// <summary>
        /// Get the jump force
        /// </summary>
        /// <returns></returns>
        int GetJumpForce();

        /// <summary>
        /// Makes the Entity jump
        /// </summary>
        /// <returns>True, if Entity has jumped else false</returns>
        bool Jump();
        
        /// <summary>
        /// Get the Entity old state
        /// </summary>
        /// <returns>The Entity previous state</returns>
        EntityState GetOldState();
        
        /// <summary>
        /// Get the Entity current state
        /// </summary>
        /// <returns>The Entity current state</returns>
        EntityState GetCurrentState();
        
        /// <summary>
        /// Set the Entity current state to a given state only if the Entity
        /// is Idle or Running
        /// </summary>
        /// <param name="state">The state to change in</param>
        void SetCurrentState(EntityState state);
        
        /// <summary>
        /// Reset the current state to a given state
        /// </summary>
        /// <param name="state">The state to change in</param>
        void ResetCurrentState(EntityState state);
        
        /// <summary>
        /// Checks if the Entity is facing right or not
        /// </summary>
        /// <returns>True, if the Entity is facing right</returns>
        bool IsFacingRight();

        /// <summary>
        /// Sets if the Entity is facing right or not
        /// </summary>
        /// <returns>True, if the Entity is facing right</returns>
        void SetFacingRight(bool condition);
        
        /// <summary>
        /// Checks if the Entity is dead
        /// </summary>
        /// <returns>True if Entity died</returns>
        bool IsDead();
        
        /// <summary>
        /// Kills the Entity
        /// </summary>
        void Die();
    }
}