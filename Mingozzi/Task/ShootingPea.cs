namespace Task
{
    /// <summary>
    /// Represents the enemy ShootingPea, a walking pea whom attack consists into shooting
    /// peas bursting from the pod's bottom.
    /// </summary>
    public class ShootingPea : AbstractPathEnemy
    {
        private const int AttackRange = 7 * 32;
        private const int IdleDuration = 2 * 60;
        private const int MaxRightOffset = 4 * 32;
        private const int AttackCooldown = 2 * 60;
        private const double MovementSpeed = 1.5;
        private const int AttackDuration = 2 * 60;

        private bool _shot;
        private int _attackDurationTicks;
        
        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="world">The game's world</param>
        public ShootingPea(World world) : base(EntityType.ShootingPea,world)
        {
            _attackDurationTicks = 0;
            _shot = false;
        }
        
        ///<inheritdoc />
        public override double GetMovementSpeed() {
            return MovementSpeed;
        }
        
        ///<inheritdoc />
        public override double GetIdleDuration() {
            return IdleDuration;
        }

        ///<inheritdoc />
        public override int GetAttackRange() {
            return AttackRange;
        }

        ///<inheritdoc />
        public override int GetMaxRightOffset() {
            return MaxRightOffset;
        }

        ///<inheritdoc />
        protected override void Attacking() {
            GetVel().SetX(0);
            if (GetShootingCooldownTicks() == 0) {
                _shot = false;
                ResetCurrentState(EntityState.Attacking);
            }
            if (GetCurrentState().Equals(EntityState.Attacking)) {
                _attackDurationTicks++;
            }
            if (_attackDurationTicks >= AttackDuration) {
                SetShootingCooldownTicks(AttackCooldown);
                _attackDurationTicks = 0;
                ResetCurrentState(EntityState.Idle);
            } else if (_attackDurationTicks >= AttackDuration / 2 && !this._shot) {
                //Here i would call the shooting method, not implemented in this translation
                _shot = true;
                SetShootingCooldownTicks(AttackCooldown);
            }
        }
        
        ///<inheritdoc />
        protected override void NotAttacking() {
            _attackDurationTicks = 0;
        }
    }
}