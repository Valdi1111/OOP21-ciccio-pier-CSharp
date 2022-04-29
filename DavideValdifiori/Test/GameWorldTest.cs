using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;
using Tasks.Blocks;
using Tasks.Entities;

namespace Test
{
    [TestClass]
    public class GameWorldTest
    {
        private const int WorldSize = 100;
        private IWorld _world;

        [TestInitialize]
        public void TestInit()
        {
            _world = new GameWorld();
            _world.Height = WorldSize;
            _world.Width = WorldSize;
            _world.Clear();
        }

        [TestMethod("Dimensions test")]
        public void TestDimensions()
        {
            Assert.AreEqual(WorldSize, _world.Height, "World height is wrong!");
            Assert.AreEqual(WorldSize, _world.Width, "World width is wrong!");
        }

        [TestMethod("Entities test")]
        public void TestEntities()
        {
            // Test create
            IEntity? e = _world.EntityFactory.CreateEntity(EntityType.Player);
            if (e is null)
            {
                Assert.Fail("Cannot create entity!");
            }

            // Test add
            _world.AddEntity(e!);
            Assert.IsTrue(_world.GetEntities().Contains(e!), "Entity add not working!");
            // Test range
            e!.Pos = new Vector2d(100, 100);
            Assert.AreEqual(1, _world.GetEntitiesInRange(new Vector2d(50, 170), 100).Count,
                "Entity inRange not working!");
            Assert.AreEqual(1, _world.GetEntitiesInRange(new Vector2d(25, 100), 100).Count,
                "Entity inRange not working!");
            Assert.AreEqual(1, _world.GetEntitiesInRange(new Vector2d(175, 100), 100).Count,
                "Entity inRange not working!");
            Assert.AreEqual(0, _world.GetEntitiesInRange(new Vector2d(250, 100), 100).Count,
                "Entity inRange not working!");
            Assert.AreEqual(1, _world.GetEntitiesInRange(new Vector2d(50, 300), 100).Count,
                "Entity inRange not working!");
            // Test remove
            _world.RemoveEntity(e!);
            Assert.IsFalse(_world.GetEntities().Contains(e!), "Entity remove not working!");
        }

        [TestMethod("Blocks test")]
        public void TestBlocks()
        {
            // Test create
            IBlock? b = _world.BlockFactory.CreateBlock(BlockType.Dirt);
            if (b is null)
            {
                Assert.Fail("Cannot create block!");
            }

            b!.Pos = new Vector2d(0, 0);
            _world.SetBlock(0, 0, b!);
            // Test get
            Assert.AreEqual(b, _world.GetBlock(0, 0), "Block get not working!");
            Assert.IsNull(_world.GetBlock(1, 0), "Block get not working!");
            Assert.IsNull(_world.GetBlock(10, 0), "Block get not working!");
            Assert.IsNull(_world.GetBlock(WorldSize, 0), "Block get not working!");
            // Test iterator
            using IEnumerator<IBlock> e = _world.GetEnumerator();
            e.MoveNext();
            Assert.AreEqual(b, e.Current, "Block iterator not working!");
            e.MoveNext();
            Assert.IsNull(e.Current, "Block iterator not working!");
        }
    }
}