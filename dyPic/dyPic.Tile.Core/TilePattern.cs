namespace dyPic.Tile.Core
{
    public class TilePattern
    {
        public TilePattern(Block[] blocks, BlocksAnimation animator)
        {
            Blocks = blocks;
            Animator = animator;
        }

        public Block[] Blocks { get; private set; }
        public BlocksAnimation Animator { get; private set; }
    }
}