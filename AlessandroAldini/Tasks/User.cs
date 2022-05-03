using System.Collections.Generic;

namespace Tasks
{
    public class User
    {
        private string _username;
        private int _soundVolume;
        private int _musicVolume;
        private Dictionary<string, int> _levelScore;

        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="username"> the identifier of the user</param>
        public User(string username)
        {
            _levelScore = new Dictionary<string, int>();
            _username = username;
            _soundVolume = 50;
            _musicVolume = 50;
            foreach (var level in Level.GetLevels)
            {
                _levelScore[level.GetName] = -1;
            }
        }

        /// <summary>
        /// getter and setter for the sound volume propriety
        /// </summary>
        public int SoundVolume
        {
            get => _soundVolume;
            set => _soundVolume = value;
        }

        /// <summary>
        /// Getter and setter for the music volume propriety
        /// </summary>
        public int MusicVolume
        {
            get => _musicVolume;
            set => _musicVolume = value;
        }

        /// <summary>
        /// Getter for the level score propriety
        /// </summary>
        public Dictionary<string, int> LevelScore => _levelScore;

        /// <summary>
        /// This method sets the score achieved in a specific level
        /// </summary>
        /// <param name="level"> The level that will have the score changed</param>
        /// <param name="score"> The score of the level</param>
        public void SetLevelScore(string level, int score)
        {
            _levelScore[level] = score;
        }

        /// <summary>
        /// The getter of the username 
        /// </summary>
        public string Username => _username;
    }
}