using System.Collections.Generic;

namespace Tasks
{
    public class User
    {
        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="username"> the identifier of the user</param>
        public User(string username)
        {
            LevelScore = new Dictionary<string, int>();
            Username = username;
            SoundVolume = 50;
            MusicVolume = 50;
            foreach (var level in Level.GetLevels)
            {
                LevelScore[level.GetName] = -1;
            }
        }

        /// <summary>
        /// getter and setter for the sound volume propriety
        /// </summary>
        public int SoundVolume { get; set; }

        /// <summary>
        /// Getter and setter for the music volume propriety
        /// </summary>
        public int MusicVolume { get; set; }

        /// <summary>
        /// Getter for the level score propriety
        /// </summary>
        public Dictionary<string, int> LevelScore { get; }

        /// <summary>
        /// This method sets the score achieved in a specific level
        /// </summary>
        /// <param name="level"> The level that will have the score changed</param>
        /// <param name="score"> The score of the level</param>
        public void SetLevelScore(string level, int score)
        {
            LevelScore[level] = score;
        }

        /// <summary>
        /// The getter of the username 
        /// </summary>
        public string Username { get; }
    }
}