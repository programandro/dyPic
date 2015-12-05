namespace dyPic.Tile.Core
{
    public class TilePattern
    {
        public TilePattern(Block[] blocks, Block fixedBlock)
        {
            Blocks = blocks;
            FixedBlock = fixedBlock;
        }

        public Block[] Blocks { get; private set; }
        public Block FixedBlock { get; private set; }
    }
}