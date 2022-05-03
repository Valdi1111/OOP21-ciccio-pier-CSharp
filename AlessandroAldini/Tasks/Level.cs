using System.Collections.Generic;

namespace Tasks
{
    public class Level
    {
        private static readonly HashSet<Level> Levels = new HashSet<Level>();
        private static readonly Level FirstLevel = new Level(null, "level-1-1.tmx", "level_1", "Level 1");
        private static readonly Level SecondLevel = new Level(FirstLevel, "level-1-2.tmx", "level_2", "Level 2");
        private static readonly Level ThirdLevel = new Level(SecondLevel, "level-1-3.tmx", "level_3", "Level 3");
        public static readonly Level BossLevel = new Level(ThirdLevel, "level-1-4.tmx", "level_4", "BOSS Level");
        private readonly Level _prevLevel;

        private Level(Level prevLevel, string fileName, string jsonId, string name)
        {
            _prevLevel = prevLevel;
            FileName = fileName;
            GetJsonId = jsonId;
            GetName = name;
            Levels.Add(this);
        }

        public string FileName { get; }

        public string GetJsonId { get; }

        public string GetName { get; }

        public static HashSet<Level> GetLevels => Levels;

        public Level GetPrevLevel()
        {
            return _prevLevel;
        }
    }
}