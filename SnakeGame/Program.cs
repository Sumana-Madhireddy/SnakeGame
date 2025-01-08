using SnakeGame;
Coord gridDimensions = new Coord(50, 20);
Coord snakePos = new Coord(10, 1);
Random rand = new Random();
Coord applePos = new Coord(rand.Next(1, gridDimensions.X-1), rand.Next(1, gridDimensions.Y - 1));
int frameDelayMilli = 500;
Direction moveDirection = Direction.Down;
int score = 0;

List<Coord> snakePosHistory = new List<Coord>();
int tailLenght = 1;

while (true)
{
    Console.Clear();
    Console.WriteLine("Score: " + score);
    snakePos.ApplyMoveDirection(moveDirection);
    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {
            Coord currentCoord = new Coord(x, y);
            if (snakePos.Equals(currentCoord) || snakePosHistory.Contains(currentCoord))
                Console.Write("■");
            else if (applePos.Equals(currentCoord))
                Console.Write("a");
            else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
                Console.Write("#");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }

    if (snakePos.Equals(applePos))
    {
        tailLenght++;
        score++;
        if (score % 3 == 0 && frameDelayMilli > 100)
        {
            frameDelayMilli -= 100;
        }
        applePos = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
    }
    else if (snakePos.X == 0 ||  snakePos.Y == 0 || 
        snakePos.X == gridDimensions.X-1 || snakePos.Y == gridDimensions.Y-1 ||
        snakePosHistory.Contains(snakePos))
    {
        score = 0;
        tailLenght = 1;
        snakePos = new Coord(10, 1);
        snakePosHistory.Clear();
        moveDirection = Direction.Down;
        frameDelayMilli = 500;
        continue;
    }

    snakePosHistory.Add(new Coord(snakePos.X, snakePos.Y));
    if (snakePosHistory.Count > tailLenght)
        snakePosHistory.RemoveAt(0);

    DateTime time = DateTime.Now;
    while ((DateTime.Now - time).Milliseconds < frameDelayMilli)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    moveDirection = Direction.Left; break;
                case ConsoleKey.RightArrow:
                    moveDirection = Direction.Right; break;
                case ConsoleKey.UpArrow:
                    moveDirection = Direction.Up; break;
                case ConsoleKey.DownArrow:
                    moveDirection = Direction.Down; break;
            }
        }
    }
}