namespace Task
{
    public interface IPlayer : ILivingEntity
    {
        int GetAttackRange();

        void AttackNearest();
    }
}