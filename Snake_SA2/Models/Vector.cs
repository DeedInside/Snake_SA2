using System.ComponentModel;

namespace Snake_SA2.Models
{
    public class Vector
    {
        private Coordinate coordinate;

        public Vector()
        {
            this.coordinate = new Coordinate(0,1);
        }

        public override string ToString()
        {
            return coordinate.ToString();
        }
        //todo методы изменения ветора и проверка
        public void MoveUp()
        {
            if (true)
            {

            }
            else
            {
                throw new Exception("Изменение вектора не возможно");
            }
        }
        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }
        public void MoveRigt()
        {

        }
    }
}
