namespace dyPic.Tile.Core
{
    public abstract class BlockAnimation
    {
        public abstract AnimationType Type { get; }
        public int BlockId { get; }
        public float DurationSeconds { get; }
    }
}