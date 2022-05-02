namespace Tasks
{
    public class EntityState
    {
        public static EntityState Idle = new EntityState("idle");
        public static EntityState Running = new EntityState("running");
        public static EntityState Jumping = new EntityState("jumping");
        public static EntityState Attacking = new EntityState("attacking");
        public static EntityState Dead = new EntityState("dead");

        private readonly string _id;

        /// <summary>
        /// Constructor for this class, create a state instance
        /// </summary>
        /// <param name="id">name to differentiate an id from another</param>
        public EntityState(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Get the state id
        /// </summary>
        public string Id => _id;

        /// <summary>
        /// Check if two id are equals
        /// </summary>
        /// <param name="other">other state</param>
        /// <returns>true, if they are the same</returns>
        private bool Equals(EntityState other)
        {
            return _id == other._id;
        }

        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EntityState)obj);
        }

        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return (_id != null ? _id.GetHashCode() : 0);
        }
    }
}