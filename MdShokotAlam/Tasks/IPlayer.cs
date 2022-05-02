namespace Tasks
{
    public interface IPlayer
    {
        /// <summary>
        /// Get the current score
        /// </summary>
        int Score { get; }

        /// <summary>
        /// Get the current coin number
        /// </summary>
        int Coin { get; }

        /// <summary>
        /// Get current stamina
        /// </summary>
        int Stamina { get; }

        /// <summary>
        /// Add to the current score
        /// </summary>
        /// <param name="score">score to add</param>
        void AddScore(int score);

        /// <summary>
        /// Increase coin number
        /// </summary>
        void AddCoin();

        /// <summary>
        /// Get the stamina max value
        /// </summary>
        /// <returns> stamina value</returns>
        int GetMaxStamina();

        /// <summary>
        /// Add to the current stamina
        /// </summary>
        /// <param name="amount">how much to add</param>
        void AddStamina(int amount);

        /// <summary>
        /// Decrease the current stamina
        /// </summary>
        /// <param name="amount">how much to decrease</param>
        void DecreaseStamina(int amount);
    }
}