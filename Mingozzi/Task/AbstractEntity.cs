namespace Task
{
    public abstract class AbstractEntity : AbstractGameObject, IEntity
    {
        private readonly World _world;
        private readonly EntityType _type;
        private bool _removed;
        
        protected AbstractEntity(EntityType type, World world):base()
        {
            this._type = type;
            this._world = world;
            this._removed = false;
        }
        
        public override int GetWidth() => this._type.GetWidth();

        public override int GetHeight() => this._type.GetHeight();

        public EntityType GetEntityType() => this._type;

        public virtual void Load()
        {
            //do nothing
        }

        public bool IsRemoved() => this._removed;

        public bool CheckCollision(IGameObject obj)
        {
            return this.GetBounds().IntersectsWith(obj.GetBounds());
        }

        public void Remove()
        {
            this._removed = true;
        }

        protected World GetWorld() => this._world;

        public abstract void Tick(long ticks);
    }
}