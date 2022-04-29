namespace Task
{
    public interface IEnemy : ILivingEntity
    {
        int GetAttackDamage();

        void AttackPlayer();
    }
}