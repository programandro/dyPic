namespace dyPic.Tile.Core
{
    public class TilePattern
    {
        public TilePattern(Block[] blocks, Block fixedBlock, IBlocksAnimator animator)
        {
            Blocks = blocks;
            Animator = animator;
            FixedBlock = fixedBlock;
        }

        public Block[] Blocks { get; private set; }
        public Block FixedBlock { get; private set; }
        public IBlocksAnimator Animator { get; private set; }
    }
}