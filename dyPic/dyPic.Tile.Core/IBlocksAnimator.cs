using System.Collections.Generic;

namespace dyPic.Tile.Core
{
    public interface IBlocksAnimator
    {
        float LoopSeconds { get; }
        Queue<BlockAnimation[]> GetNextAnimation();
    }
}