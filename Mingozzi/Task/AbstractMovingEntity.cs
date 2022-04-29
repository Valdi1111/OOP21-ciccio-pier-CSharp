using System.Drawing;
using System.Runtime.CompilerServices;

namespace Task
{
    public abstract class AbstractMovingEntity : AbstractEntity,IMovingEntity
    {
        private Vector2D _vel;
        
        protected AbstractMovingEntity(EntityType type, World world) : base(type,world)
        {
            this._vel = new Vector2D();
        }

        public abstract override void Tick(long ticks);

        public Vector2D GetVel() => this._vel;

        public void SetVel(Vector2D vel)
        {
            this._vel = vel;
        }

        protected Rectangle RectangleOffset()
        {
            Vector2D entityOffset = this.GetPos().AddVector(this._vel);
            return new Rectangle(entityOffset.GetX(),
                entityOffset.GetY(),
                this.GetWidth(),
                this.GetHeight());
        }
            
        
        //MISSING COLLISIONS
    }

}