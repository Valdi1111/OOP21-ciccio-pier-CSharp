using System.Drawing;

namespace Task
{
    public abstract class AbstractGameObject : IGameObject
    {
        private Vector2D _pos;

        protected AbstractGameObject()
        {
            this._pos = new Vector2D();
        }

        public Vector2D GetPos() => this._pos;

        public void SetPos(Vector2D pos)
        {
            this._pos = pos;
        }

        public abstract int GetWidth();
        public abstract int GetHeight();

        public Rectangle GetBounds() => new Rectangle(this.GetPos().GetX(), this.GetPos().GetY(), this.GetWidth(), this.GetHeight());
    }
}