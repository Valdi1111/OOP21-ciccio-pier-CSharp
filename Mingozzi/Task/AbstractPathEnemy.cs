namespace Task
{
    /// <summary>
    /// Class that abstracts an Enemy whom movement behaviour consists of patrolling a path
    /// </summary>
    public abstract class AbstractPathEnemy : AbstractEnemy,IPathEnemy
    {
        private int _leftPathfurthest;
        private int _rightPathfurthest;
        private int _currentDest;
        private int _idleTicks;
        
        /// <summary>
        /// Constructor for this class.
        /// Initializes all the common fields for enemies with a movement path behaviour
        /// </summary>
        /// <param name="type">The Entity's type</param>
        /// <param name="world">The game's world</param>
        protected AbstractPathEnemy(EntityType type, World world) : base(type, world)
        {
            
        }

        ///<inheritdoc />
        public override void Load()
        {
            InitializePath(GetMaxRightOffset());
        }
        
        /// <summary>
        /// Method used to set up the path and assign the X-axis extremes of the path
        /// This can't be done in the constructor due to having the initial position assigned
        /// after being created, therefore this method gets called by the load function, called
        /// once for each entity after being spawned in the game world [IN THE FULL PROJECT]
        /// </summary>
        /// <param name="maxRightOffset">The offset for the right extreme of this path</param>
        private void InitializePath(int maxRightOffset) {
            _leftPathfurthest = GetPos().GetX();
            _rightPathfurthest = _leftPathfurthest + maxRightOffset;
            _currentDest = _leftPathfurthest;
        }

        ///<inheritdoc />
        public abstract int GetMaxRightOffset();

        ///<inheritdoc />
        public abstract int GetAttackRange();

        ///<inheritdoc />
        public abstract double GetMovementSpeed();

        ///<inheritdoc />
        public abstract double GetIdleDuration();

        /// <summary>
        /// Utility method used to check if the Enemy is in the conditions to attack the player.
        /// The conditions to begin attacking are for the player to be within range and for the
        /// Enemy to be facing the player.
        /// The conditions to stop attacking are either the player moved out of range or the Enemy is not
        /// facing him anymore
        /// </summary>
        private void CheckAttackConditions() {
            if (StartAggro(GetAttackRange()) && FacingPlayer()) {
                SetAttacking(true);
            }
            if (!PlayerInAggroRange(GetAttackRange()) || !FacingPlayer()) {
                SetAttacking(false);
            }
        }

        /// <summary>
        /// Method called every tick if the Enemy is not dead, before moving.
        /// Based on the Enemy attacking or not, two different methods get called.
        /// These two methods are left empty to be implemented in each individual Enemy.
        /// If the Enemy is attacking, this method returns true so that the tick does not continue
        /// and the Enemy does not follow its default moving behaviour
        /// </summary>
        /// <returns>True, if the Enemy is currently attacking</returns>
        private bool AttackBehaviour() 
       {
            CheckAttackConditions();
            if (IsAttacking()) 
            {
                Attacking();
                return true;
            } 
            else 
            {
                NotAttacking();
                return false;
            }
       }

        /// <summary>
        /// Method called when then Enemy is attacking.
        /// It is left empty to be overridden
        /// </summary>
        protected abstract void Attacking();

        /// <summary>
        /// Method called when then Enemy is not attacking.
        /// It is left empty to be overridden
        /// </summary>
        protected abstract void NotAttacking();
        
        /// <summary>
        /// Method that defines the common movement behaviour for all path enemies.
        /// </summary>
        /// <param name="movementSpeed">The speed of the movement</param>
        /// <param name="idleDuration">The duration of the idle at each extreme</param>
        private void PathMovementBehaviour(double movementSpeed, double idleDuration) {
            if (GetPos().GetX() == _currentDest
                && _idleTicks < idleDuration) {
                ResetCurrentState(EntityState.Idle);
                GetVel().SetX(0);
                _idleTicks++;
            } else if (GetPos().GetX() == _currentDest) {
                _currentDest = _currentDest == _leftPathfurthest ? _rightPathfurthest : _leftPathfurthest;
                _idleTicks = 0;
                ResetCurrentState(EntityState.Running);
            } else {
                GetVel().SetX(_currentDest == _leftPathfurthest ? -movementSpeed : movementSpeed);
                ResetCurrentState(EntityState.Running);
            }
            Move();
        }

        ///<inheritdoc />
        public override void Tick(long ticks) {
            base.Tick(ticks);
            if (IsDead()) {
                return;
            }
            if (AttackBehaviour()) {
                return;
            }
            PathMovementBehaviour(GetMovementSpeed(), GetIdleDuration());
        }
    }
}