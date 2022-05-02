namespace Task
{
    /// <summary>
    /// Extension of basic entity states, adding some states used by Enemies
    /// </summary>
    public class EnemyState : EntityState
    {
        public static readonly EnemyState AngeredRunning = new EnemyState("aggro_running");
        public static readonly EnemyState Angered = new EnemyState("angered");
        public static readonly EnemyState Hidden = new EnemyState("hidden");
        public static readonly EnemyState JumpingIn = new EnemyState("jumping_in");
        public static readonly EnemyState JumpingOut = new EnemyState("jumping_out");
        public static readonly EnemyState SlashIn = new EnemyState("slash_in");
        public static readonly EnemyState SlashOut = new EnemyState("slash_out");

        ///<inheritdoc />
        private EnemyState(string id) : base(id)
        {
            
        }
    }
}