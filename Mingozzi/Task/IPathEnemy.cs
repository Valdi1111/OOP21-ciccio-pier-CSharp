namespace Task
{
    /// <summary>
    /// Represents an enemy whom behaviour is defined on a path it patrols
    /// </summary>
    public interface IPathEnemy : IEnemy
    {
        /// <summary>
        /// Retrieves the path offset
        /// </summary>
        /// <returns>The offset of the max path to the right</returns>
        int GetMaxRightOffset();
        
        /// <summary>
        /// Retrieves the attack range of the Enemy
        /// </summary>
        /// <returns>The Enemy's attack range</returns>
        int GetAttackRange();
        
        /// <summary>
        /// Retrieves the movement speed of the Enemy
        /// </summary>
        /// <returns>The Enemy's movement speed</returns>
        double GetMovementSpeed();
        
        /// <summary>
        /// Retrieves the idle duration of the Enemy
        /// </summary>
        /// <returns>The Enemy's idle duration</returns>
        double GetIdleDuration();
    }
}