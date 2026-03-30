namespace Snake_SA2.Models
{
    public class Coordinate
    {
        public ushort X = 0;
        public ushort Y = 0;
        public Coordinate(ushort x, ushort y)
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
