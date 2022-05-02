namespace Task
{
    /// <summary>
    /// Class that abstracts an Entity that can be either alive or dead
    /// </summary>
    public abstract class AbstractLivingEntity : AbstractMovingEntity, ILivingEntity
    {
        private const int JumpForce = 16;
        private const int MaxTime = 35;

        private readonly int _maxHp;
        private int _hp;
        private readonly bool _ground;
        private bool _dead;
        private bool _isReady;
        private bool _facingRight;
        private int _time;
        private EntityState _oldState;
        private EntityState _currentState;
        
        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="type">The Entity's type</param>
        /// <param name="world">The game's world</param>
        protected AbstractLivingEntity(EntityType type, World world) : base(type,world)
        {
            _ground = false;
            _maxHp = GetEntityType().GetMaxHp();
            _hp = _maxHp;
            _dead = false;
            _isReady = true;
            _facingRight = true;
            _currentState = EntityState.Idle;
            _oldState = EntityState.Idle;
            _time = 0;
        }
        
        ///<inheritdoc />
        public int GetHp() => _hp;

        ///<inheritdoc />
        public int GetMaxHp() => _maxHp;

        ///<inheritdoc />
        public void Damage(int amount)
        {
            _hp -= amount;
            if (_hp <= 0)
            {
                _hp = 0;
                Die();
            }
        }

        ///<inheritdoc />
        public void Heal(int amount)
        {
            _hp += amount;
            if (_hp >= _maxHp)
            {
                _hp = _maxHp;
            }
        }

        ///<inheritdoc />
        public int GetJumpForce() => JumpForce;

        ///<inheritdoc />
        public bool Jump()
        {
            if (_isReady && _ground) {
                SetCurrentState(EntityState.Jumping);
                GetVel().SetY(-GetJumpForce());
                _isReady = false;
                _time = 0;
                return true;
            }
            return false;
        }

        ///<inheritdoc />
        public EntityState GetOldState() => _oldState;

        ///<inheritdoc />
        public EntityState GetCurrentState() => _currentState;

        ///<inheritdoc />
        public void SetCurrentState(EntityState state)
        {
            if (Equals(_currentState, EntityState.Idle) || Equals(state, EntityState.Dead))
            {
                _currentState = state;
            }
        }

        ///<inheritdoc />
        public void ResetCurrentState(EntityState state)
        {
            _currentState = state;
        }

        ///<inheritdoc />
        public bool IsFacingRight() => _facingRight;

        ///<inheritdoc />
        public void SetFacingRight(bool condition)
        {
            _facingRight = condition;
        }

        ///<inheritdoc />
        public bool IsDead() => _dead;

        ///<inheritdoc />
        public void Die()
        {
            SetCurrentState(EntityState.Dead);
            _dead = true;
        }
        
        ///<inheritdoc />
        public override void Tick(long ticks)
        {
            _oldState = GetCurrentState();
            if (_time >= MaxTime)
            {
                _isReady = true;
            }
            else
            {
                _time++;
            }
        }

        /// <summary>
        /// Method that moves the Entity
        /// </summary>
        protected void Move()
        {
            if (GetVel().GetX() > 0)
            {
                SetFacingRight(true);
            }
            else
            {
                SetFacingRight(false);
            }
            GetPos().Add(GetVel());
        }
    }
}