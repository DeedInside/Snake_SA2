namespace Snake_SA2.Models
{
    public class Coordinate
    {
        public short X = 0;
        public short Y = 0;
        public Coordinate(short x, short y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"[{X}:{Y}]";
        }
    }
}
