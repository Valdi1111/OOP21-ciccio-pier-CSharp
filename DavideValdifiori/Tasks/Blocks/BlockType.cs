namespace Tasks.Blocks
{
    /// <summary>
    /// Represents the block types.
    /// </summary>
    public class BlockType
    {
        /// <summary>
        /// Represents a null block.
        /// </summary>
        public static readonly BlockType Air = new BlockType(false);

        /// <summary>
        /// Represents a grass block.
        /// </summary>
        public static readonly BlockType Grass = new BlockType();

        /// <summary>
        /// Represents a dirt block.
        /// </summary>
        public static readonly BlockType Dirt = new BlockType();

        /// <summary>
        /// Represents a cursed dirt block.
        /// </summary>
        public static readonly BlockType CursedDirt = new BlockType();

        /// <summary>
        /// Represents a stone block.
        /// </summary>
        public static readonly BlockType Stone = new BlockType();

        /// <summary>
        /// Represents a stone brick block.
        /// </summary>
        public static readonly BlockType StoneBrick = new BlockType();

        /// <summary>
        /// Represents a cracked stone brick block.
        /// </summary>
        public static readonly BlockType CrackedStoneBrick = new BlockType();

        /// <summary>
        /// Represents a mossy stone brick block.
        /// </summary>
        public static readonly BlockType MossyStoneBrick = new BlockType();

        /// <summary>
        /// Represents a chiseled stone brick block.
        /// </summary>
        public static readonly BlockType ChiseledStoneBrick = new BlockType();

        /// <summary>
        /// Represents a coal ore block.
        /// </summary>
        public static readonly BlockType CoalOre = new BlockType();

        /// <summary>
        /// Represents a wood plank block.
        /// </summary>
        public static readonly BlockType WoodPlank = new BlockType();

        /// <summary>
        /// Represents a wood log block.
        /// </summary>
        public static readonly BlockType WoodLogSide = new BlockType();

        /// <summary>
        /// Represents a wood log block.
        /// </summary>
        public static readonly BlockType WoodLogTop = new BlockType();

        /// <summary>
        /// Represents a cobblestone block.
        /// </summary>
        public static readonly BlockType Cobblestone = new BlockType();

        /// <summary>
        /// Represents a mossy cobblestone block.
        /// </summary>
        public static readonly BlockType MossyCobblestone = new BlockType();

        /// <summary>
        /// Represents a white tulip block.
        /// </summary>
        public static readonly BlockType WhiteTulip = new BlockType(false);

        /// <summary>
        /// Represents a red tulip block.
        /// </summary>
        public static readonly BlockType RedTulip = new BlockType(false);

        /// <summary>
        /// Represents a glow stone block.
        /// </summary>
        public static readonly BlockType GlowStone = new BlockType(false);

        /// <summary>
        /// Represents a lapis ore block.
        /// </summary>
        public static readonly BlockType LapisOre = new BlockType();

        /// <summary>
        /// Represents a diamond ore block.
        /// </summary>
        public static readonly BlockType DiamondOre = new BlockType();

        /// <summary>
        /// Represents a nether dirt block.
        /// </summary>
        public static readonly BlockType NetherDirt = new BlockType();

        /// <summary>
        /// Represents a quartz ore block.
        /// </summary>
        public static readonly BlockType QuartzOre = new BlockType();

        /// <summary>
        /// Represents a nether gold ore block.
        /// </summary>
        public static readonly BlockType NetherGoldOre = new BlockType();

        /// <summary>
        /// Represents a red nether brick block.
        /// </summary>
        public static readonly BlockType RedNetherBrick = new BlockType(false);

        /// <summary>
        /// Represents a nether brick block.
        /// </summary>
        public static readonly BlockType NetherBrick = new BlockType();

        /// <summary>
        /// Represents a cracked nether brick block.
        /// </summary>
        public static readonly BlockType CrackedNetherBrick = new BlockType();

        /// <summary>
        /// Represents a chiseled nether brick block.
        /// </summary>
        public static readonly BlockType ChiseledNetherBrick = new BlockType();

        /// <summary>
        /// Represents an obsidian block.
        /// </summary>
        public static readonly BlockType Obsidian = new BlockType(false);

        /// <summary>
        /// Represents a portal block.
        /// </summary>
        public static readonly BlockType Portal = new BlockType(false, true);

        /// <summary>
        /// Represents a nether flower block.
        /// </summary>
        public static readonly BlockType NetherFlower = new BlockType(false);

        /// <summary>
        /// Represents a graveyard grass block.
        /// </summary>
        public static readonly BlockType GraveyardGrass = new BlockType();

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave1 = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave2 = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave3Top = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave4Top = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave5Top = new BlockType(false);

        /// <summary>
        /// Represents a dead tree block.
        /// </summary>
        public static readonly BlockType DeadTree1Top = new BlockType(false);

        /// <summary>
        /// Represents a dead tree block.
        /// </summary>
        public static readonly BlockType DeadTree2Top = new BlockType(false);

        /// <summary>
        /// Represents a mossy rock block.
        /// </summary>
        public static readonly BlockType MossyRockLeft = new BlockType(false);

        /// <summary>
        /// Represents a mossy rock block.
        /// </summary>
        public static readonly BlockType MossyRockRight = new BlockType(false);

        /// <summary>
        /// Represents a graveyard dirt block.
        /// </summary>
        public static readonly BlockType GraveyardDirt = new BlockType();

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave6 = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave7 = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave3Bottom = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave4Bottom = new BlockType(false);

        /// <summary>
        /// Represents a grave block.
        /// </summary>
        public static readonly BlockType Grave5Bottom = new BlockType(false);

        /// <summary>
        /// Represents a dead tree block.
        /// </summary>
        public static readonly BlockType DeadTree1Bottom = new BlockType(false);

        /// <summary>
        /// Represents a dead tree block.
        /// </summary>
        public static readonly BlockType DeadTree2Bottom = new BlockType(false);

        /// <summary>
        /// Represents a mausoleum block.
        /// </summary>
        public static readonly BlockType MausoleumTopLeft = new BlockType(false, true);

        /// <summary>
        /// Represents a mausoleum block.
        /// </summary>
        public static readonly BlockType MausoleumTopRight = new BlockType(false, true);

        /// <summary>
        /// Represents a graveyard stone block.
        /// </summary>
        public static readonly BlockType GraveyardStone = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrick = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrickLeft = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrickLeftTop = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrickTopFlat = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrickRightTop = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrickRight = new BlockType();

        /// <summary>
        /// Represents a boss brick block.
        /// </summary>
        public static readonly BlockType BossBrickTopArc = new BlockType();

        /// <summary>
        /// Represents a mausoleum block.
        /// </summary>
        public static readonly BlockType MausoleumBottomLeft = new BlockType(false, true);

        /// <summary>
        /// Represents a mausoleum block.
        /// </summary>
        public static readonly BlockType MausoleumBottomRight = new BlockType(false, true);

        /// <summary>
        /// Represents a fire block.
        /// </summary>
        public static readonly BlockType Fire = new BlockType(false);

        private readonly bool _solid;
        private readonly bool _interact;

        /// <summary>
        /// Create a new block type given the texture coordinates. Solid block.
        /// </summary>
        private BlockType() : this(true)
        {
        }

        /// <summary>
        /// Create a new block type given the texture coordinates.
        /// </summary>
        /// <param name="solid">if the block is solid or not</param>
        private BlockType(bool solid) : this(solid, false)
        {
        }

        /// <summary>
        /// Create a new block type given the texture coordinates.
        /// </summary>
        /// <param name="solid">if the block is solid or not</param>
        /// <param name="interact">if you can interact with the block or not</param>
        private BlockType(bool solid, bool interact)
        {
            _solid = solid;
            _interact = interact;
        }

        /// <summary>
        /// Check if this type of block is solid or not.
        /// </summary>
        /// <returns>true if solid, false otherwise</returns>
        public bool IsSolid() => _solid;

        /// <summary>
        /// Check if this type of block can be interacted with
        /// </summary>
        /// <returns>true if you can interact with it, false otherwise</returns>
        public bool CanInteract() => _interact;
    }
}