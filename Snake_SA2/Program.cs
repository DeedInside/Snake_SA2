using Snake_SA2.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Field field = new Field(20,10);
        Snake snake = new Snake();

        Console.WriteLine("start game");
        bool start = true;
        field.Render();
        field.field[snake.Head.X][snake.Head.Y] = '@';
        while (start)
        {
            Console.Clear();
            field.Draw();
            char move = Console.ReadKey().KeyChar;
            switch (move)
            {
                case 'w':
                    {
                        try
                        {
                            snake.Vector.MoveUp(); //изменить вектор
                            snake.Move(); //изменить координату головы
                           //изменить координату головы на поле
                        }
                        catch
                        {

                        }
                        break;
                    }
                case 's':
                    {
                        break;
                    }
                case 'a':
                    {
                        break;
                    }
                case 'd':
                    {
                        break;
                    }
                case '1':
                    {
                        start = false;
                        break;
                    }
            }
        }
        Console.WriteLine("end game");
    }
}