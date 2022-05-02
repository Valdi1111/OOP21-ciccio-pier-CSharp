namespace Task
{
    /// <summary>
    /// Simple class to store the instance of entities states
    /// </summary>
    public class EntityState
    {
        public static readonly EntityState Idle = new EntityState("idle");
        public static readonly EntityState Running = new EntityState("running");
        public static readonly EntityState Jumping = new EntityState("jumping");
        public static readonly EntityState Attacking = new EntityState("attacking");
        public static readonly EntityState Dead = new EntityState("dead");

        private readonly string _id;

        /// <summary>
        /// Constructor for this class, create a state instance
        /// </summary>
        /// <param name="id">The id name to identify the state</param>
        protected EntityState(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Get the state id
        /// </summary>
        /// <returns>The id</returns>
        private string GetId()
        {
            return _id;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (this == obj) {
                return true;
            }
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }
            EntityState that = (EntityState) obj;
            return GetId().Equals(that.GetId());
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
        
        /// <inheritdoc />
        public override string ToString()
        {
            return _id;
        }
    }
}