namespace dyPic.Tile.Core
{
    public class Block
    {
        public Block(int id, Size size)
        {
            Id = id;
            Size = size;
        }

        public int Id { get; private set; }
        public Size Size { get; private set; }
    }
}