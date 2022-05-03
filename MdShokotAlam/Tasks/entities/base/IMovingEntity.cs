namespace Tasks.entities.@base
{
    /// <summary>
    /// Represents a moving Entity
    /// </summary>
    public interface IMovingEntity : IEntity
    {
        /// <summary>
        /// Returns the Entity movement
        /// </summary>
        /// <returns>Entity's movement's 2dVector</returns>
        Vector2d GetVel();

        /// <summary>
        /// Sets the Entity movement
        /// </summary>
        /// <param name="vel">Entity's new movement</param>
        void SetVel(Vector2d vel);
    }
}