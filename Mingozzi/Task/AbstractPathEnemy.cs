namespace Task
{
    public abstract class AbstractPathEnemy : AbstractEnemy,IPathEnemy
    {
        private int _leftPathfurthest;
        private int _rightPathfurthest;
        private int _currentDest;
        private int _idleTicks;

        
        protected AbstractPathEnemy(EntityType type, World world) : base(type, world)
        {
            
        }

        public override void Load()
        {
            this.InitializePath(this.GetMaxRightOffset());
        }

        private void InitializePath(int maxRightOffset) {
            this._leftPathfurthest = this.GetPos().GetX();
            this._rightPathfurthest = this._leftPathfurthest + maxRightOffset;
            this._currentDest = this._leftPathfurthest;
        }

        public abstract int GetMaxRightOffset();

        public abstract int GetAttackRange();

        public abstract double GetMovementSpeed();

        public abstract double GetIdleDuration();
        
        protected void CheckAttackConditions() {
            if (this.StartAggro(this.GetAttackRange()) && this.FacingPlayer()) {
                this.SetAttacking(true);
            }
            if (!this.PlayerInAggroRange(this.GetAttackRange()) || !this.FacingPlayer()) {
                this.SetAttacking(false);
            }
        }
        
       protected bool AttackBehaviour() 
       {
            this.CheckAttackConditions();
            if (this.IsAttacking()) 
            {
                this.Attacking();
                return true;
            } 
            else 
            {
                this.NotAttacking();
                return false;
            }
        }


        protected abstract void Attacking();


        protected abstract void NotAttacking();
        

        private void PathMovementBehaviour(double movementSpeed, double idleDuration) {
            if (this.GetPos().GetX() == this._currentDest
                    && this._idleTicks < idleDuration) {
                this.ResetCurrentState(EntityState.IDLE);
                this.GetVel().SetX(0);
                this._idleTicks++;
            } else if (this.GetPos().GetX() == this._currentDest) {
                this._currentDest = this._currentDest == this._leftPathfurthest ? this._rightPathfurthest : this._leftPathfurthest;
                this._idleTicks = 0;
                this.ResetCurrentState(EnemyState.RUNNING);
            } else {
                this.GetVel().SetX(this._currentDest == this._leftPathfurthest ? -movementSpeed : movementSpeed);
                this.ResetCurrentState(EntityState.RUNNING);
            }
            this.Move();
        }

        public override void Tick(long ticks) {
            base.Tick(ticks);
            if (this.IsDead()) {
                return;
            }
            if (this.AttackBehaviour()) {
                return;
            }
            this.PathMovementBehaviour(this.GetMovementSpeed(), this.GetIdleDuration());
        }
        
    }
}