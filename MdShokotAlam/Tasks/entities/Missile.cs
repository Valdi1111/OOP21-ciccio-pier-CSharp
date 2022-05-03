using System;
using Tasks.entities.@base;

namespace Tasks.entities
{
    /// <summary>
    /// Create a simple missile that chase the player
    /// </summary>
    public class Missile : SimpleMovingEntity
    {
        private const int MinDistance = 70;
        private const int MaxDistance = 150;
        private const int MaxAngle = 45; //in degree
        private const int MaxSpeed = 8;
        private const double MaxSteering = 0.2;

        private readonly Random _random;
        private readonly Vector2d _accel;
        private readonly int _maxTravelDistance;
        private int _currentDistance;

        /// <summary>
        /// Constructor for this class, create a Missile instance
        /// </summary>
        /// <param name="world">world</param>
        public Missile(IWorld world) : base(EntityType.Missile, world)
        {
            SetVel(new Vector2d(0, -6));
            _accel = new Vector2d();
            _random = new Random();
            _maxTravelDistance = _random.Next(MinDistance, MaxDistance);
            //rotate by a _random number
            GetVel().RotateInDegree(RandAngleInRange());
            _currentDistance = 0;
        }

        /// <summary>
        /// Generate a _random angle in range from -MaxAngle to MaxAngle
        /// </summary>
        /// <returns>angle in degree</returns>
        private double RandAngleInRange()
        {
            double randAngleInDegree = _random.Next(MaxAngle);

            if (_random.Next(1) == 0)
            {
                return randAngleInDegree;
            }

            return -randAngleInDegree;
        }

        /// <summary>
        /// Check if the missile has travel the maxTravelDistance
        /// </summary>
        /// <returns>true if max distance reached else false</returns>
        private bool IsMaxDistance()
        {
            _currentDistance += (int)GetVel().GetMagnitude();
            return _currentDistance >= _maxTravelDistance;
        }

        /// <summary>
        /// Apply any type of force to the missile like wind force, gravity etc...
        /// </summary>
        /// <param name="force">force to apply to the missile</param>
        private void ApplyForce(Vector2d force)
        {
            _accel.Add(force);
        }

        /// <summary>
        /// Make the missile seek the player
        /// </summary>
        private void Seek()
        {
            //player pos with a offset
            Vector2d playerPos = GetWorld().Player().GetPos().Clone();
            // desired Velocity of the missile
            Vector2d desire = GetPos().DirectionVector(playerPos);
            desire.SetMagnitude(MaxSpeed);
            // steering force = desire - velocity
            Vector2d steering = desire.SubVector(GetVel());
            steering.SetLimiter(MaxSteering);
            ApplyForce(steering);
        }

        public new void Tick(long ticks)
        {
            //seek the player if i reached the max distance
            if (IsMaxDistance())
            {
                Seek();
            }

            GetVel().Add(_accel);
            GetVel().SetLimiter(MaxSpeed);
            GetPos().Add(GetVel());
            //reset the _accel vector
            _accel.Set(0, 0);
            //check player collision
        }
    }
}