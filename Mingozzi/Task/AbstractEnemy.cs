namespace Task
{
    public abstract class AbstractEnemy : AbstractLivingEntity, IEnemy
    {
        
        const int HIT_COOLDOWN = 120;
        const int DEATH_DURATION = 120;
        private readonly int _attackDamage;
        private int _shootingCooldownTicks;
        private int _hitTicks;
        private int _deathTicks;
        private bool _attacking;
        
        protected AbstractEnemy(EntityType type, World world) : base(type,world)
        {
            this._attackDamage = this.GetEntityType().GetAttackDamage();
            this._deathTicks = 0;
            this._shootingCooldownTicks = 0;
            this._hitTicks = 0;
            this._attacking = false;
            this.SetFacingRight(false);
        }

        public int GetAttackDamage() => _attackDamage;

        public void AttackPlayer()
        {
            this.GetWorld().GetPlayer().Damage(this._attackDamage);
        }
        
        protected void CheckPlayerCollision() {
            if (this.GetWorld().GetPlayer().CheckCollision(this) && this._hitTicks == 0) {
                this.AttackPlayer();
                this._hitTicks = HIT_COOLDOWN;
            }
        }
        
        public void SetAttacking(bool cond) {
            this._attacking = cond;
        }


        public bool IsAttacking() => this._attacking;
        
        public void SetShootingCooldownTicks(int ticks) {
            this._shootingCooldownTicks = ticks;
        }

        public int GetShootingCooldownTicks() => this._shootingCooldownTicks;
        
        protected bool PlayerInAggroRange(int range) {
            int pivot = this.GetPos().GetX();
            int playerPos = this.GetWorld().GetPlayer().GetPos().GetX();
            return (playerPos >= pivot - range) && (playerPos <= pivot + range);
        }
        
        protected bool StartAggro(int range)
        {
            return this.PlayerInAggroRange(range) &&
                   this.GetPos().GetY() + this.GetEntityType().GetHeight()
                   == GetWorld().GetPlayer().GetPos().GetY() + GetWorld().GetPlayer().GetHeight();
        }
        
        protected bool FacingPlayer() {
            return (this.GetWorld().GetPlayer().GetPos().GetX() < this.GetPos().GetX() && !this.IsFacingRight()) ||
                   (this.GetWorld().GetPlayer().GetPos().GetX() > this.GetPos().GetX() && this.IsFacingRight());
        }
        
        private void UpdateHitTicks() {
            if (this._hitTicks > 0) {
                this._hitTicks--;
            }
        }

        /**
     * Utility method that keeps track of the shooting cooldown when needed
     */
        protected void UpdateShootingCooldownTicks() {
            if (this._shootingCooldownTicks > 0) {
                this._shootingCooldownTicks--;
            }
        }
        
        
        
        private bool CheckDyingBehaviour() {
            if (this.IsDead()) {
                this.ResetCurrentState(EnemyState.DEAD);
                this.SetVel(new Vector2D(0, 5));
            }
            if (this.GetCurrentState().Equals(EnemyState.DEAD)) {
                this._deathTicks++;
                if (this._deathTicks == DEATH_DURATION) {
                    this.Remove();
                }
                return true;
            }
            return false;
        }
        
        
        public override void Tick(long ticks)
        {
            base.Tick(ticks);
            if (this.CheckDyingBehaviour()) {
                return; 
            }
            this.UpdateHitTicks();
            this.CheckPlayerCollision();
            this.UpdateShootingCooldownTicks();
        }
    }
}