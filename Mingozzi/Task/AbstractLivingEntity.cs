namespace Task
{
    public abstract class AbstractLivingEntity : AbstractMovingEntity, ILivingEntity
    {
        private readonly int MAX_GRAVITY = 20;
        private readonly int JUMP_FORCE = 16;
        private readonly int MAX_TIME = 35;
        
        private readonly Vector2D _gravity;
        private readonly int _maxHp;
        private int _hp;
        private bool _ground;
        private bool _dead;
        private bool _isReady;
        private bool _facingRight;
        private int _time;
        private EntityState _oldState;
        private EntityState _currentState;
        
        protected AbstractLivingEntity(EntityType type, World world) : base(type,world)
        {
            this._ground = false;
            this._maxHp = this.GetEntityType().GetMaxHp();
            this._hp = this._maxHp;
            this._dead = false;
            this._gravity = new Vector2D(0, 1);
            this._isReady = true;
            this._facingRight = true;
            this._currentState = EntityState.IDLE;
            this._oldState = EntityState.IDLE;
            this._time = 0;
        }



        public int GetHp() => this._hp;

        public int GetMaxHp() => this._maxHp;

        public void Damage(int amount)
        {
            this._hp -= amount;
            if (this._hp <= 0)
            {
                this._hp = 0;
                this.Die();
            }
        }

        public void Heal(int amount)
        {
            this._hp += amount;
            if (this._hp >= this._maxHp)
            {
                this._hp = this._maxHp;
            }
        }

        public int GetJumpForce() => this.JUMP_FORCE;

        public bool Jump()
        {
            if (this._isReady && this._ground) {
                this.SetCurrentState(EntityState.JUMPING);
                this.GetVel().SetY(-this.GetJumpForce());
                this._isReady = false;
                this._time = 0;
                return true;
            }
            return false;
        }

        public EntityState GetOldState() => this._oldState;

        public EntityState GetCurrentState() => this._currentState;

        public void SetCurrentState(EntityState state)
        {
            if (this._currentState == EntityState.IDLE || state == EntityState.DEAD)
            {
                this._currentState = state;
            }
        }

        public void ResetCurrentState(EntityState state)
        {
            this._currentState = state;
        }

        public bool IsFacingRight() => this._facingRight;

        public void SetFacingRight(bool condition)
        {
            this._facingRight = condition;
        }

        public bool IsDead() => this._dead;

        public void Die()
        {
            this.SetCurrentState(EntityState.DEAD);
            this._dead = true;
        }
        
        public override void Tick(long ticks)
        {
            this._oldState = this.GetCurrentState();
            if (this._time >= MAX_TIME)
            {
                this._isReady = true;
            }
            else
            {
                this._time++;
            }
        }

        protected void Move()
        {
            this.GetPos().Add(this.GetVel());
        }
    }
}