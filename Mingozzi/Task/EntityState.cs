namespace Task
{
    public class EntityState
    {
        public static readonly EntityState IDLE = new EntityState("idle");
        public static readonly EntityState RUNNING = new EntityState("running");
        public static readonly EntityState JUMPING = new EntityState("jumping");
        public static readonly EntityState ATTACKING = new EntityState("attacking");
        public static readonly EntityState DEAD = new EntityState("dead");

        private readonly string _id;

        /// <summary>
        /// Constructor for this class, create a state instance
        /// </summary>
        /// <param name="id">The id name to identify the state</param>
        public EntityState(string id)
        {
            this._id = id;
        }

        /// <summary>
        /// Get the state id
        /// </summary>
        /// <returns>The id</returns>
        public string getId()
        {
            return this._id;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (this == obj) {
                return true;
            }
            if (obj == null || this.GetType() != obj.GetType()) {
                return false;
            }
            EntityState that = (EntityState) obj;
            return this.getId().Equals(that.getId());
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        /// <inheritdoc />
        public override string ToString()
        {
            return this._id;
        }
    }
}