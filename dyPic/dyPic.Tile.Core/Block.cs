namespace dyPic.Tile.Core
{
    public class Block
    {
        public Block(int id, Size size, Point position)
        {
            Id = id;
            Size = size;
            Position = position;
        }

        public int Id { get; private set; }
        public Size Size { get; private set; }
        public Point Position { get; private set; }
    }
}