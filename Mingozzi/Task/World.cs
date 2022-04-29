using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Task
{
    public class World : IWorld
    {
        private readonly List<IEntity> _entities;
        private readonly Player _player;

        public World()
        {
            this._entities = new List<IEntity>();
            this._player = new Player(this);
        }

        public List<IEntity> GetEntities() => new List<IEntity>(this._entities);

        public void AddEntity(IEntity entity)
        {
            this._entities.Add(entity);
        }

        public void RemoveEntity(IEntity entity)
        {
            this._entities.Remove(entity);
        }

        public IPlayer GetPlayer() => this._player;
    }
}