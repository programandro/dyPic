using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyPic.Tile.Core
{
    public class SizeBoundary
    {
        public SizeBoundary(Size min, Size max, Size desired)
        {
            Min = min;
            Max = max;
            Desired = desired;
        }

        public Size Min { get; private set; }
        public Size Max { get; private set; }
        public Size Desired { get; private set; }
    }
}
