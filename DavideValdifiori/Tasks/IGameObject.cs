namespace Tasks
{
    /// <summary>
    /// Represents a generic object in the <see cref="IWorld"/>.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Width of the object.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Height of the object.
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Position inside of the <see cref="IWorld"/>.
        /// </summary>
        Vector2d Pos { get; set; }
    }
}