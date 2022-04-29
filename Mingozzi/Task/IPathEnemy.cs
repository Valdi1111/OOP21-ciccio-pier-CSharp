namespace Task
{
    public interface IPathEnemy : IEnemy
    {
        int GetMaxRightOffset();
        
        int GetAttackRange();
        
        double GetMovementSpeed();
        
        double GetIdleDuration();
    }
}