using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyPic.Tile.Core.Animations
{
    public class SimpleAnimation : IBlocksAnimator
    {
        public SimpleAnimation(Block[] initialBlocks)
            : this(initialBlocks, 0.5f, 10)
        { }

        public SimpleAnimation(Block[] initialBlocks, float seconds, float percent)
        {
            ids = initialBlocks.Select(b => b.Id).ToList();
            maxId = ids.Max();
            LoopSeconds = seconds;
            Percent = percent;
        }

        private List<int> ids;
        private int maxId;

        public float Percent { get; private set; }

        public float LoopSeconds{ get; private set; }

        public Queue<BlockAnimation[]> GetNextAnimation()
        {
            Random r = new Random();
            int length = ids.Count;            
            int count = Math.Max((int)(length * Percent / 100), 1);
            float duration = Math.Min(LoopSeconds / count, 0.1f);

            Queue<BlockAnimation[]> result = new Queue<BlockAnimation[]>();
            for (int i = 0; i < count; i++)
            {
                int index = r.Next(ids.Count);
                BlockAnimation inAnimation = new FadeInAnimation(ids[index], duration);
                BlockAnimation outAnimation = new FadeOutAnimation(maxId + 1, duration);
                maxId++;
                ids.RemoveAt(index);
                ids.Insert(index, maxId);
                result.Enqueue(new BlockAnimation[] { inAnimation, outAnimation });
            }

            return result;
        }
    }
}
