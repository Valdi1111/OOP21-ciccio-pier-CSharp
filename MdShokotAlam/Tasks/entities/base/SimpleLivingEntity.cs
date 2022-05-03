namespace Tasks.entities.@base
{
    public class SimpleLivingEntity : SimpleMovingEntity, ILivingEntity
    {
        public SimpleLivingEntity(EntityType entityType, IWorld world) : base(entityType, world)
        {
        }
    }
}