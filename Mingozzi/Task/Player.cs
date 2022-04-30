using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task;

namespace Task
{
    /// <summary>
    /// Represents the Player
    /// </summary>
    public class Player : AbstractLivingEntity,IPlayer
    {
        private const int AttackRange = 3 * 32;
        
        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="world">The game's world</param>
        public Player(World world) : base(EntityType.Player, world)
        {
            
        }

        ///<inheritdoc />
        public int GetAttackRange() => AttackRange;
        
        ///<inheritdoc />
        public void AttackNearest()
        {
            SetCurrentState(EntityState.Attacking);
            Vector2D playerCenter = GetPos().AddVector(new Vector2D(GetWidth() / 2d, GetHeight() / 2d));
            var enemy = GetWorld().GetEntities()
                .Where(t => t is ILivingEntity)
                .Cast<IEnemy>()
                .Where(t =>
                {
                    Vector2D enemyCenter = t.GetPos().AddVector(new Vector2D(t.GetWidth() / 2d, t.GetHeight() / 2d));
                    if (enemyCenter.GetX() < playerCenter.GetX() - AttackRange ||
                        enemyCenter.GetX() > playerCenter.GetX() + AttackRange)
                    {
                        return false;
                    }
                    if (t.IsDead() || t.GetCurrentState().Equals(EnemyState.Hidden))
                    {
                        return false;
                    }
                    if (!(playerCenter.GetY() >= t.GetPos().GetY() &&
                          playerCenter.GetY() <= (t.GetPos().GetY() + t.GetHeight())))
                    {
                        return false;
                    }
                    if (this.IsFacingRight())
                    {
                        return enemyCenter.GetX() > playerCenter.GetX();
                    }
                    return enemyCenter.GetX() < playerCenter.GetX();
                })
                .OrderBy(t => t, new DisComparer(playerCenter))
                .ToList()
                .FirstOrDefault();
            if (enemy != null)
            {
                enemy.Damage(GetEntityType().GetAttackDamage());
            }
        }
    }
    
    ///<inheritdoc />
    public class DisComparer : IComparer<IEnemy>
    {
        private readonly Vector2D _playerCenter;
        
        /// <summary>
        /// Constructor for this comparer for enemies distances
        /// </summary>
        /// <param name="playerCenter">The center of Player from which the distance is compared</param>
        public DisComparer(Vector2D playerCenter)
        {
            _playerCenter = playerCenter;
        }
    
        ///<inheritdoc />
        public int Compare(IEnemy t1, IEnemy t2)
        {
            if (t1 == null)
            {
                return -1;
            }
            else if (t2 == null)
            {
                return 1;
            }
            if (Math.Abs(_playerCenter.GetX() - t1.GetPos().GetX()) < Math.Abs(_playerCenter.GetX() - t2.GetPos().GetX())) 
            {
                return -1;
            } 
            else if (Math.Abs(_playerCenter.GetX() - t1.GetPos().GetX()) > Math.Abs(_playerCenter.GetX() - t2.GetPos().GetX())) 
            {
                return 1;
            }
            return 0;
        }
    }
}