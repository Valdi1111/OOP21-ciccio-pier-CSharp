namespace Task
{
    /// <summary>
    /// Abstract class that generalizes the movement model of Entities
    /// </summary>
    public abstract class AbstractMovingEntity : AbstractEntity,IMovingEntity
    {
        private Vector2D _vel;
        
        /// <summary>
        /// Utility method to obtain a reference of the location the Entity
        /// will be when velocity will be applied
        /// </summary>
        /// <param name="type"></param>
        /// <param name="world"></param>
        protected AbstractMovingEntity(EntityType type, World world) : base(type,world)
        {
            _vel = new Vector2D();
        }

        ///<inheritdoc />
        public abstract override void Tick(long ticks);

        ///<inheritdoc />
        public Vector2D GetVel() => _vel;

        ///<inheritdoc />
        public void SetVel(Vector2D vel)
        {
            _vel = vel;
        }
    }
}