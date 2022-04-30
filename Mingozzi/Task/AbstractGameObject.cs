using System.Drawing;

namespace Task
{
    /// <summary>
    /// Abstract class that generalizes all basic traits for any Object for the Game 
    /// </summary>
    public abstract class AbstractGameObject : IGameObject
    {
        private Vector2D _pos;

        /// <summary>
        /// Constructor for this class, it instantiates pos at 0, 0.
        /// </summary>
        protected AbstractGameObject()
        {
            _pos = new Vector2D();
        }

        ///<inheritdoc />
        public Vector2D GetPos() => _pos;

        ///<inheritdoc />
        public void SetPos(Vector2D pos)
        {
            _pos = pos;
        }

        ///<inheritdoc />
        public abstract int GetWidth();
        
        ///<inheritdoc />
        public abstract int GetHeight();

        ///<inheritdoc />
        public Rectangle GetBounds() => new Rectangle(GetPos().GetX(), GetPos().GetY(), GetWidth(), GetHeight());
    }
}