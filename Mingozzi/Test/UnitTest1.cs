using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private static IWorld _world;
        
        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            _world = new World();
        }
        
        [TestMethod]
        public void TestSetUp ()
        {
            Assert.IsNotNull(_world);
            Assert.IsNotNull(_world.GetPlayer());
            
        }
    }
}