namespace Task
{
    public class EnemyState : EntityState
    {
        public static readonly EnemyState ANGERED_RUNNING = new EnemyState("aggro_running");
        public static readonly EnemyState ANGERED = new EnemyState("angered");
        public static readonly EnemyState HIDDEN = new EnemyState("hidden");
        public static readonly EnemyState JUMPING_IN = new EnemyState("jumping_in");
        public static readonly EnemyState JUMPING_OUT = new EnemyState("jumping_out");
        public static readonly EnemyState SLASH_IN = new EnemyState("slash_in");
        public static readonly EnemyState SLASH_OUT = new EnemyState("slash_out");

        ///<inheritdoc />
        public EnemyState(string id) : base(id){}
    }
}