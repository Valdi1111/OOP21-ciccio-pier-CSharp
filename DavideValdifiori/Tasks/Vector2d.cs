namespace Tasks
{
    /// <summary>
    /// Dummy class for representing a vector.
    /// </summary>
    public class Vector2d
    {
        /// <summary>
        /// Dummy constructor for this class.
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public Vector2d(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public int Y { get; set; }
    }
}