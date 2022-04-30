namespace Tasks
{
    /// <summary>
    /// Simple implementation of the interface <see cref="IGameObject"/>.
    /// </summary>
    public abstract class SimpleGameObject : IGameObject
    {
        /// <summary>
        /// Constructor for this class, it instantiates pos at 0, 0.
        /// </summary>
        protected SimpleGameObject()
        {
            Pos = new Vector2d(0, 0);
        }

        /// <inheritdoc/>>
        public abstract int Width { get; }

        /// <inheritdoc/>>
        public abstract int Height { get; }

        /// <inheritdoc/>>
        public Vector2d Pos { get; set; }
    }
}