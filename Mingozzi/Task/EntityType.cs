namespace Task
{
    public class EntityType
    {

        public static readonly EntityType PLAYER = new EntityType(32,64,1000,60);
        public static readonly EntityType SHOOTING_PEA = new EntityType(32,64,130,100);
        
        private readonly int _width;
        private readonly int _height;
        private readonly int _maxHp;
        private readonly int _attackDamage;
        
        public EntityType(int width, int height, int maxHp, int attackDamage)
        {
            this._width = width;
            this._height = height;
            this._maxHp = maxHp;
            this._attackDamage = attackDamage;
        }

        public int GetWidth() {
            return this._width;
        }


        public int GetHeight() {
            return this._height;
        }


        public int GetMaxHp() {
            return this._maxHp;
        }


        public int GetAttackDamage() {
            return this._attackDamage;
        }
        
    }
}