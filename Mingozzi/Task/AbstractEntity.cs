namespace Task
{
    /// <summary>
    /// Abstract class that generalizes all basic traits of any kind of Entity
    /// </summary>
    public abstract class AbstractEntity : AbstractGameObject, IEntity
    {
        private readonly World _world;
        private readonly EntityType _type;
        private bool _removed;
        
        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="type">The Entity's type</param>
        /// <param name="world">The game's world</param>
        protected AbstractEntity(EntityType type, World world)
        {
            _type = type;
            _world = world;
            _removed = false;
        }
        
        ///<inheritdoc />
        public override int GetWidth() => _type.GetWidth();

        ///<inheritdoc />
        public override int GetHeight() => _type.GetHeight();

        ///<inheritdoc />
        public EntityType GetEntityType() => _type;

        ///<inheritdoc />
        public virtual void Load()
        {
            //do nothing
        }

        ///<inheritdoc />
        public bool IsRemoved() => _removed;

        ///<inheritdoc />
        public bool CheckCollision(IGameObject obj)
        {
            return GetBounds().IntersectsWith(obj.GetBounds());
        }

        ///<inheritdoc />
        public void Remove()
        {
            _removed = true;
        }
        
        ///<inheritdoc />
        public abstract void Tick(long ticks);
        
        /// <summary>
        /// Retrieve the World the Entity is placed in
        /// </summary>
        /// <returns>The world</returns>
        protected World GetWorld() => _world;
    }
}