using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace Test
{
    [TestClass]
    public class TestPlayer
    {
        [TestMethod]
        public void TestPlayerStamina()
        {
            PlayerImpl playerImpl = new PlayerImpl();

            Assert.AreEqual(playerImpl.GetMaxStamina(), playerImpl.Stamina,
                "Failed to start with max samina ");
            const int damage = 50;
            playerImpl.DecreaseStamina(damage);
            Assert.AreEqual(playerImpl.GetMaxStamina() - damage, playerImpl.Stamina,
                "Failed to decrease player stamina");
            const int heal = 10;
            playerImpl.AddStamina(heal);
            Assert.AreEqual(playerImpl.GetMaxStamina() - damage + heal, playerImpl.Stamina,
                "Failed to heal player stamina");
        }

        [TestMethod]
        public void TestPlayerCoin()
        {
            PlayerImpl playerImpl = new PlayerImpl();
            Assert.IsTrue(playerImpl.Coin == 0, "Failed to start as 0");
            playerImpl.AddCoin();
            playerImpl.AddCoin();
            playerImpl.AddCoin();
            Assert.AreEqual(3, playerImpl.Coin, "failed to add coin");
        }

        [TestMethod]
        public void TestPlayerScore()
        {
            PlayerImpl playerImpl = new PlayerImpl();
            Assert.IsTrue(playerImpl.Score == 0, "Failed to start as 0");
            playerImpl.AddScore(10);
            playerImpl.AddScore(20);
            playerImpl.AddScore(20);
            Assert.AreEqual(50, playerImpl.Score, "failed to add score");
        }
    }
}