using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private static World _world;
        private static ShootingPea _shootingPea;
        private static int _ticks;
        
        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            _world = new World();
            _shootingPea = new ShootingPea(_world);
            _world.AddEntity(_shootingPea);
            _shootingPea.SetPos(_world.GetPlayer().GetPos().AddVector(new Vector2D(_shootingPea.GetAttackRange()-1,0)));
            _shootingPea.Load();
        }
        
        [TestMethod]
        public void Test00SetUp ()
        {
            Assert.IsNotNull(_world);
            Assert.IsNotNull(_world.GetPlayer());
            Assert.IsNotNull(_shootingPea);
            Assert.IsTrue(_world.GetEntities().Count.Equals(1));
        }

        [TestMethod]
        public void Test01Movement()
        {
            _ticks = 0;
            var shootingPea = new ShootingPea(_world);
            _world.AddEntity(shootingPea);
            shootingPea.SetPos(new Vector2D(0,100));
            shootingPea.Load();
            for (var tmp = 0; tmp < shootingPea.GetIdleDuration() + 60; tmp++)
            {
                shootingPea.Tick(++_ticks);
            }
            Assert.IsTrue(shootingPea.GetPos().GetX()>0);
        }
        
        [TestMethod]
        public void Test02Status()
        {
            _ticks = 0;
            Assert.AreEqual(EntityState.Idle,_shootingPea.GetCurrentState());
            _shootingPea.Tick(++_ticks);
            Assert.AreEqual(EntityState.Attacking,_shootingPea.GetCurrentState());
            _world.GetPlayer().SetPos(_shootingPea.GetPos().AddVector(new Vector2D(EntityType.ShootingPea.GetWidth()*2,0)));
            _shootingPea.Tick(++_ticks);
            Assert.AreEqual(EntityState.Idle,_shootingPea.GetCurrentState());
        }

        [TestMethod]
        public void Test03PlayerAttack()
        {
            _world.GetPlayer().SetPos(new Vector2D());
            _shootingPea.SetPos(_world.GetPlayer().GetPos().AddVector(new Vector2D(_world.GetPlayer().GetAttackRange()-1,0)));
            Assert.AreEqual(EntityType.ShootingPea.GetMaxHp(),_shootingPea.GetHp());
            _world.GetPlayer().AttackNearest();
            Assert.AreEqual(EntityType.ShootingPea.GetMaxHp()-EntityType.Player.GetAttackDamage(),_shootingPea.GetHp());
        }
    }
}