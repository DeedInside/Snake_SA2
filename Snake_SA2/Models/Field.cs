using System.Runtime.ExceptionServices;

namespace Snake_SA2.Models
{
    public class Field
    {
        private ushort wight;
        private ushort hight;
        public List<List<char>> field = new List<List<char>>();
        public Field(ushort wight = 10, ushort hight = 10)
        {
            this.wight = wight;
            this.hight = hight;
        }
        public void Draw()
        {
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < wight; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void Render()
        {
            for (int i = 0; i < hight; i++)
            {
                field.Add(new List<char>());
                for (int j = 0; j < wight; j++)
                {
                    if(i == 0 || i == hight - 1)
                    {
                        field[i].Add('-');
                    }
                    else if ((i != 0 && i != hight - 1) && j == 0 || j == wight - 1)
                    {
                        field[i].Add('|');
                    }
                    else
                    {
                        field[i].Add(' ');
                    }
                }
            }
        }
    }
}
