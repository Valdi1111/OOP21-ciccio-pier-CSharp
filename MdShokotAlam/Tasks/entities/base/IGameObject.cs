namespace Tasks.entities.@base
{
    /// <summary>
    ///  Represents a generic object in the World.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Get the position inside the World.
        /// </summary>
        /// <returns>the position</returns>
        Vector2d GetPos();

        /// <summary>
        /// Set the position inside the World.
        /// </summary>
        /// <param name="pos">pos the new position</param>
        void SetPos(Vector2d pos);
    }
}