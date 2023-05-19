namespace Snake
{
    class Program
    {
        private static void Main()
        {
            //Console.SetWindowSize(400, 400);
            //Console.SetBufferSize(300, 300);

            HorizontalLine hLineTop = new HorizontalLine(0, 300, 0, '+');
            hLineTop.DrawFigure();
            HorizontalLine hLineDown = new HorizontalLine(0, 300, 300, '+');
            hLineDown.DrawFigure();

            VerticalLine vLineLeft = new VerticalLine(0, 0, 300, '+');
            vLineLeft.DrawFigure();
            VerticalLine vLineRight = new VerticalLine(300, 0, 300, '+');
            vLineRight.DrawFigure();

            Point p1 = new Point(5, 50, '*');
            p1.Draw();

            Point p2 = new Point(50, 10, '#');
            p2.Draw();

            Point snakePoint = new Point(15, 15, '=');
            Snake snake = new Snake(snakePoint, 4, Direction.RIGHT);
            snake.DrawFigure();
            snake.Move();

            FoodCreator foodCreator = new FoodCreator(80, 80, '$');
            Point food = foodCreator.CreateFood();
            food.Draw(); 

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeMove(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}