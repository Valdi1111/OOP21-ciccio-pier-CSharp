using System.Collections.Generic;

namespace Tasks
{
    /// <summary>
    /// This class define the levels of the game
    /// </summary>
    public class Level
    {
        private static readonly HashSet<Level> Levels = new HashSet<Level>();
        private static readonly Level FirstLevel = new Level(null, "level-1-1.tmx", "level_1", "Level 1");
        private static readonly Level SecondLevel = new Level(FirstLevel, "level-1-2.tmx", "level_2", "Level 2");
        private static readonly Level ThirdLevel = new Level(SecondLevel, "level-1-3.tmx", "level_3", "Level 3");
        public static readonly Level BossLevel = new Level(ThirdLevel, "level-1-4.tmx", "level_4", "BOSS Level");
        private readonly Level _prevLevel;

        /// <summary>
        /// This constructor generates and adds a new level
        /// </summary>
        /// <param name="prevLevel"> the level that needs to be played before this one</param>
        /// <param name="fileName"> the name of the file</param>
        /// <param name="jsonId"> the identification in the json file</param>
        /// <param name="name"> the name of the level</param>
        private Level(Level prevLevel, string fileName, string jsonId, string name)
        {
            _prevLevel = prevLevel;
            FileName = fileName;
            JsonId = jsonId;
            GetName = name;
            Levels.Add(this);
        }

        /// <summary>
        /// This is a getter and setter for the file name
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// This is a getter and setter for the json id
        /// </summary>
        public string JsonId { get; }

        /// <summary>
        /// This is a getter and setter for the level name
        /// </summary>
        public string GetName { get; }

        /// <summary>
        /// this is a getter for the level hash set
        /// </summary>
        public static HashSet<Level> GetLevels => Levels;

        /// <summary>
        /// this is a getter for the previous level
        /// </summary>
        public Level GetPrevLevel => _prevLevel;
    }
}