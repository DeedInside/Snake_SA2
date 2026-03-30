using Snake_SA2.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("start game");
        bool start = true;
        while (start)
        {
            char move = Console.ReadKey().KeyChar;
            Snake snake = new Snake();
            switch (move)
            {
                case 'w':
                    {
                        try
                        {
                            snake.Vector.MoveUp(); //изменить вектор
                            snake.Move(); //изменить координату головы
                            Console.WriteLine(snake.Head);
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