using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tasks.Blocks;
using Tasks.Entities;

namespace Tasks
{
    /// <summary>
    /// Simple implementation of the interface <see cref="IWorld"/>.
    /// </summary>
    public class GameWorld : IWorld
    {
        private IBlock[,] _blocks;
        private List<IEntity> _entities;

        /// <summary>
        /// Constructor for this class, it instantiates entity and block factories.
        /// <see cref="set_Height"/>, <see cref="set_Width"/> and <see cref="Clear"/> must be called after this.
        /// </summary>
        public GameWorld()
        {
            EntityFactory = new SimpleEntityFactory(this);
            BlockFactory = new SimpleBlockFactory();
            _blocks = new IBlock[0, 0];
            _entities = new List<IEntity>(0);
            Player = null;
        }

        /// <inheritdoc/>
        public IEntityFactory EntityFactory { get; }

        /// <inheritdoc/>
        public IBlockFactory BlockFactory { get; }

        /// <inheritdoc/>
        public int Height { get; set; }

        /// <inheritdoc/>
        public int Width { get; set; }

        /// <inheritdoc/>
        public IBlock? GetBlock(int x, int y)
        {
            if (x >= Width || y >= Height)
            {
                return null;
            }

            return _blocks[y, x];
        }

        /// <inheritdoc/>
        public void SetBlock(int x, int y, IBlock block) => _blocks[y, x] = block;

        /// <inheritdoc/>
        public List<IEntity> GetEntities() => new List<IEntity>(_entities);

        /// <inheritdoc/>
        public List<IEntity> GetEntitiesInRange(Vector2d pos, int radius)
        {
            return _entities
                .Where(e => Math.Abs(e.Pos.X - pos.X) < radius || Math.Abs(e.Pos.X + e.Width + pos.X) < radius)
                .ToList();
        }

        /// <inheritdoc/>
        public void AddEntity(IEntity entity) => _entities.Add(entity);

        /// <inheritdoc/>
        public void RemoveEntity(IEntity entity) => _entities.Remove(entity);

        /// <inheritdoc/>
        public IPlayer? Player { get; private set; }

        /// <inheritdoc/>
        public void Clear()
        {
            _blocks = new IBlock[Height, Width];
            _entities = new List<IEntity>();
            Player = EntityFactory.CreatePlayer();
        }

        /// <inheritdoc/>
        public IEnumerator<IBlock> GetEnumerator() => new BlockEnumerator(_blocks);

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    /// <summary>
    /// Simple utility class for the block iterator.
    /// </summary>
    public class BlockEnumerator : IEnumerator<IBlock>
    {
        private readonly IBlock[,] _blocks;
        private int _column;
        private int _row;

        public BlockEnumerator(IBlock[,] blocks)
        {
            _blocks = blocks;
            Reset();
        }

        public bool MoveNext()
        {
            if (_column >= _blocks.GetLength(1))
            {
                _column = -1;
                _row++;
            }

            _column++;
            return _column >= _blocks.GetLength(0);
        }

        public void Reset()
        {
            _column = -1;
            _row = 0;
        }

        public IBlock Current => _blocks[_row, _column];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Do nothing.
        }
    }
}