namespace Task
{
    /// <summary>
    /// Abstract class representing a generic Enemy
    /// </summary>
    public abstract class AbstractEnemy : AbstractLivingEntity, IEnemy
    {
        private const int HitCooldown = 120;
        private const int DeathDuration = 120;
        private readonly int _attackDamage;
        private int _shootingCooldownTicks;
        private int _hitTicks;
        private int _deathTicks;
        private bool _attacking;
        
        /// <summary>
        /// Constructor for this class
        /// Initializes all the common fields for enemies
        /// </summary>
        /// <param name="type">The Entity's type</param>
        /// <param name="world">The game's world</param>
        protected AbstractEnemy(EntityType type, World world) : base(type,world)
        {
            _attackDamage = GetEntityType().GetAttackDamage();
            _deathTicks = 0;
            _shootingCooldownTicks = 0;
            _hitTicks = 0;
            _attacking = false;
            SetFacingRight(false);
        }

        ///<inheritdoc />
        public int GetAttackDamage() => _attackDamage;

        ///<inheritdoc />
        public void AttackPlayer()
        {
            GetWorld().GetPlayer().Damage(_attackDamage);
        }

        /// <summary>
        /// Method that defines the common collision hit behaviour between a generic enemy and the player
        /// </summary>
        private void CheckPlayerCollision() {
            if (GetWorld().GetPlayer().CheckCollision(this) && _hitTicks == 0) {
                AttackPlayer();
                _hitTicks = HitCooldown;
            }
        }

        /// <summary>
        /// Method used to set if the enemy is attacking
        /// </summary>
        /// <param name="cond">True, if the enemy is currently attacking</param>
        protected void SetAttacking(bool cond) {
            _attacking = cond;
        }

        /// <summary>
        /// Checks if the enemy is currently attacking or not
        /// </summary>
        /// <returns>True, if the enemy is attacking</returns>
        protected bool IsAttacking() => _attacking;

        /// <summary>
        /// Method used to start the cooldown after the Enemy has shot
        /// </summary>
        /// <param name="ticks">The ticks</param>
        protected void SetShootingCooldownTicks(int ticks) {
            _shootingCooldownTicks = ticks;
        }

        /// <summary>
        /// Retrieve the shooting cooldown
        /// </summary>
        /// <returns>The cooldown ticks</returns>
        protected int GetShootingCooldownTicks() => _shootingCooldownTicks;
        
        /// <summary>
        /// Utility method to check if the player is inside the enemy range
        /// </summary>
        /// <param name="range">The enemy range to detect the player</param>
        /// <returns>True if conditions are met</returns>
        protected bool PlayerInAggroRange(int range) {
            int pivot = GetPos().GetX();
            int playerPos = GetWorld().GetPlayer().GetPos().GetX();
            return (playerPos >= pivot - range) && (playerPos <= pivot + range);
        }
        
        /// <summary>
        /// Utility method to check if the player is inside the enemy range and on his same height
        /// </summary>
        /// <param name="range">The enemy range to detect the player</param>
        /// <returns>True, if conditions are met</returns>
        protected bool StartAggro(int range)
        {
            return PlayerInAggroRange(range) &&
                   GetPos().GetY() + GetEntityType().GetHeight()
                   == GetWorld().GetPlayer().GetPos().GetY() + GetWorld().GetPlayer().GetHeight();
        }
        
        /// <summary>
        /// Utility method to check if the enemy is currently facing the player
        /// </summary>
        /// <returns>True, if the enemy is facing the player</returns>
        protected bool FacingPlayer() {
            return (GetWorld().GetPlayer().GetPos().GetX() < GetPos().GetX() && !IsFacingRight()) ||
                   (GetWorld().GetPlayer().GetPos().GetX() > GetPos().GetX() && IsFacingRight());
        }
        
        /// <summary>
        /// Utility method that keeps track of the hit ticks when needed
        /// </summary>
        private void UpdateHitTicks() {
            if (_hitTicks > 0) {
                _hitTicks--;
            }
        }

        /// <summary>
        /// Utility method that keeps track of the shooting cooldown when needed
        /// </summary>
        private void UpdateShootingCooldownTicks() {
            if (_shootingCooldownTicks > 0) {
                _shootingCooldownTicks--;
            }
        }

        /// <summary>
        /// Method that defines the common death behaviour for all enemies.
        /// It returns a boolean due to being the only thing to do when an Enemy dies,
        /// therefore when it returns true, the tick function stops.
        /// </summary>
        /// <returns>True, if the Enemy is dead.</returns>
        private bool CheckDyingBehaviour() {
            if (IsDead()) {
                ResetCurrentState(EntityState.Dead);
                SetVel(new Vector2D(0, 5));
            }
            if (GetCurrentState().Equals(EntityState.Dead)) {
                _deathTicks++;
                if (_deathTicks == DeathDuration) {
                    Remove();
                }
                return true;
            }
            return false;
        }
        
        ///<inheritdoc />
        public override void Tick(long ticks)
        {
            base.Tick(ticks);
            if (CheckDyingBehaviour()) {
                return; 
            }
            UpdateHitTicks();
            CheckPlayerCollision();
            UpdateShootingCooldownTicks();
        }
    }
}