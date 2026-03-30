namespace Snake_SA2.Models
{
    public class Snake
    {
        public int Id;
        public Coordinate Head;
        public Vector Vector;
        public int Lenght;
        public int Speed;
        public Snake(int speed = 1)
        {
            Id = 1;
            Head = new Coordinate(2,2);
            Vector = new Vector();
            Lenght = 2;
            Speed = speed;
        }
        //todo смещения головы по вектору
        public void Move()
        {

        }
    }
}
