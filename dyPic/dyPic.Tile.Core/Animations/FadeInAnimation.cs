using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyPic.Tile.Core.Animations
{
    public class FadeInAnimation : BlockAnimation
    {
        public FadeInAnimation(int blockId, float duration) : base(blockId, AnimationType.In, duration)
        { }
    }
}
