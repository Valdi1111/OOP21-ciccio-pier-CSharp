using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task;

namespace Task
{
    public class Player : AbstractLivingEntity,IPlayer
    {
        private const int ATTACK_RANGE = 3 * 32;
        public Player(World world) : base(EntityType.PLAYER, world)
        {
            
        }

        public int GetAttackRange() => ATTACK_RANGE;
        
        public void AttackNearest()
        {
            this.SetCurrentState(EntityState.ATTACKING);
            Vector2D playerCenter = this.GetPos().AddVector(new Vector2D(this.GetWidth() / 2d, this.GetHeight() / 2d));
            IEnemy enemy = this.GetWorld().GetEntities()
                .Where(t => t.GetType().IsSubclassOf(typeof(ILivingEntity)))
                .Cast<IEnemy>()
                .Where(t =>
                {
                    Vector2D enemyCenter = t.GetPos().AddVector(new Vector2D(t.GetWidth() / 2d, t.GetHeight() / 2d));

                    if (enemyCenter.GetX() < playerCenter.GetX() - ATTACK_RANGE ||
                        enemyCenter.GetX() > playerCenter.GetX() + ATTACK_RANGE)
                    {
                        return false;
                    }

                    if (t.IsDead() || t.GetCurrentState().Equals(EnemyState.HIDDEN))
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
                enemy.Damage(this.GetEntityType().GetAttackDamage());
            }
        }
    }
 
    public class DisComparer : IComparer<IEnemy>
    {
        private Vector2D _playerCenter;
        public DisComparer(Vector2D playerCenter)
        {
            this._playerCenter = playerCenter;
        }
    
        public int Compare(IEnemy t1, IEnemy t2)
        {
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