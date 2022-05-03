namespace Tasks.entities.@base
{
    public abstract class SimpleGameObject : IGameObject
    {
        private Vector2d _pos;

        /// <summary>
        /// Constructor for this class, it instantiates pos at 0, 0.
        /// </summary>
        protected SimpleGameObject()
        {
            _pos = new Vector2d(0, 0);
        }

        /// <inheritdoc/>
        public Vector2d GetPos()
        {
            return _pos;
        }

        /// <inheritdoc/>
        public void SetPos(Vector2d pos)
        {
            _pos = pos;
        }
    }
}