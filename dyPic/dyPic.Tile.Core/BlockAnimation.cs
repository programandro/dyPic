namespace dyPic.Tile.Core
{
    public abstract class BlockAnimation
    {
        public BlockAnimation(int blockId, AnimationType animationType, float duration)
        {
            AnimationType = animationType;
            BlockId = blockId;
            Duration = duration;
        }

        public AnimationType AnimationType { get; protected set; }
        public int BlockId { get; protected set; } 
        public float Duration { get; protected set; } // In seconds
    }
}