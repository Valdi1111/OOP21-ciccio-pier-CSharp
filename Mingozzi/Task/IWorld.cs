using System.Collections.Generic;

namespace Task
{
    public interface IWorld
    {
        List<IEntity> GetEntities();

        void AddEntity(IEntity entity);
        
        void RemoveEntity(IEntity entity);

        IPlayer GetPlayer();
    }
}