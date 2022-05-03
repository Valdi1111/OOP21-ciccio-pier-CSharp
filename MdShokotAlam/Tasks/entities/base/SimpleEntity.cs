namespace Tasks.entities.@base
{
    public class SimpleEntity : SimpleGameObject, IEntity
    {
        private EntityType _type;
        private IWorld _world;

        public SimpleEntity(EntityType type, IWorld world)
        {
            _world = world;
            _type = type;
        }

        public new EntityType GetType()
        {
            return _type;
        }

        public void Tick(long ticks)
        {
        }

        /// <summary>
        /// World's getter
        /// </summary>
        /// <returns>The game's world</returns>
        protected IWorld GetWorld()
        {
            return _world;
        }
    }
}