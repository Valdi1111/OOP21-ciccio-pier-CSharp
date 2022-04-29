namespace Task
{
    public class ShootingPea : AbstractPathEnemy
    {
        public static readonly int ATTACK_RANGE = 7 * 32;
        public static readonly int IDLE_DURATION = 2 * 60;
        public static readonly int MAX_RIGHT_OFFSET = 4 * 32;
        public static readonly int ATTACK_COOLDOWN = 2 * 60;
        public static readonly double MOVEMENT_SPEED = 1.5;
        public static readonly int ATTACK_DURATION = 2 * 60;

        private bool shot;
        private int attackDurationTicks;
        
        public ShootingPea(World world) : base(EntityType.SHOOTING_PEA,world)
        {
            this.attackDurationTicks = 0;
            this.shot = false;
        }
        
        public override double GetMovementSpeed() {
            return MOVEMENT_SPEED;
        }
        
        public override double GetIdleDuration() {
            return IDLE_DURATION;
        }


        public override int GetAttackRange() {
            return ATTACK_RANGE;
        }

        public override int GetMaxRightOffset() {
            return MAX_RIGHT_OFFSET;
        }

        protected override void Attacking() {
            this.GetVel().SetX(0);
            if (this.GetShootingCooldownTicks() == 0) {
                this.shot = false;
                this.ResetCurrentState(EntityState.ATTACKING);
            }
            if (this.GetCurrentState().Equals(EnemyState.ATTACKING)) {
                this.attackDurationTicks++;
            }
            if (this.attackDurationTicks >= ATTACK_DURATION) {
                this.SetShootingCooldownTicks(ATTACK_COOLDOWN);
                this.attackDurationTicks = 0;
                this.ResetCurrentState(EntityState.IDLE);
            } else if (this.attackDurationTicks >= ATTACK_DURATION / 2 && !this.shot) {
                //Here i would call the shooting method, not implemented in this translation
                this.shot = true;
                this.SetShootingCooldownTicks(ATTACK_COOLDOWN);
            }
        }

        protected override void NotAttacking() {
            this.attackDurationTicks = 0;
        }
    }
}