namespace Tasks.Entities
{
    /// <summary>
    /// Dummy class for representing an entity implementation.
    /// </summary>
    public abstract class SimpleEntity : SimpleGameObject, IEntity
    {
        /// <summary>
        /// Dummy constructor for this class.
        /// </summary>
        /// <param name="world">the world</param>
        protected SimpleEntity(IWorld world)
        {
        }

        /// <summary>
        /// Width of the entity.
        /// </summary>
        public override int Width => 32;

        /// <summary>
        /// Height of the entity.
        /// </summary>
        public override int Height => 32;
    }
}