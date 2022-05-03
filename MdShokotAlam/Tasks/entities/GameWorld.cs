using Tasks.entities.@base;

namespace Tasks.entities
{
    public class GameWorld : IWorld
    {
        private IPlayer _player;

        public void Clear()
        {
            _player = new PlayerImpl(this);
        }

        IPlayer IWorld.Player()
        {
            return _player;
        }
    }
}