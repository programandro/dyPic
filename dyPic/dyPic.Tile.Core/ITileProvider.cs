using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyPic.Tile.Core
{
    public interface ITileProvider
    {
        TilePattern GetTile(Size screenSize, int blockCount, SizeBoundary fixedTileLimits);
    }
}
