using Tasks.entities.@base;

namespace Tasks
{
    public class PlayerImpl : SimpleLivingEntity, IPlayer
    {
        private const int MaxStamina = 200;

        /// <summary>
        /// Constructor for this class
        /// </summary>
        public PlayerImpl(IWorld world) : base(EntityType.Player, world)
        {
            Score = 0;
            Coin = 0;
            Stamina = MaxStamina;
        }

        /// <inheritdoc/>
        public int Score { get; private set; }

        /// <inheritdoc/>
        public int Coin { get; private set; }

        /// <inheritdoc/>
        public int Stamina { get; private set; }

        /// <inheritdoc/>
        public void AddScore(int score)
        {
            Score += score;
        }

        /// <inheritdoc/>
        public void AddCoin()
        {
            Coin++;
        }

        /// <inheritdoc/>
        public int GetMaxStamina()
        {
            return MaxStamina;
        }

        /// <inheritdoc/>
        public void AddStamina(int amount)
        {
            Stamina += amount;
            if (Stamina > GetMaxStamina()) Stamina = GetMaxStamina();
        }

        /// <inheritdoc/>
        public void DecreaseStamina(int amount)
        {
            Stamina -= amount;
            if (Stamina < 0)
                Stamina = 0;
            //damage here
        }
    }
}