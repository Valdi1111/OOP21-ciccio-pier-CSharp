namespace Task
{
    public interface IMovingEntity : IEntity
    {
        /// <summary>
        /// Returns the Entity movement
        /// </summary>
        /// <returns> Entity's movement velocity</returns>
        Vector2D GetVel();

        /// <summary>
        /// Set the Entity movement
        /// </summary>
        /// <param name="vel"> Entity's new movement</param>
        void SetVel(Vector2D vel);
    }
}