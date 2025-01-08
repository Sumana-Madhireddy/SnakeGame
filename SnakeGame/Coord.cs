using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Coord
    {   //store the X and Y coordinates of the point.
        private int x;
        private int y;
        //read-only properties that allow external code to access the values of x and y.
        public int X { get { return x; } }
        public int Y { get { return y; } }
        //Initializes a Coord object with specific values for x and y
        public Coord(int x, int y)
        {
            this .x = x;
            this .y = y;
            //The this keyword is used to refer to the instance fields x and y.
        }
        //Compares two Coord objects to determine if they are equal.
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                    return false;
            Coord other = (Coord) obj;
            return x == other.x && y == other.y;
        }

        public void ApplyMoveDirection(Direction direction)
        {
            switch(direction)
            {
                case Direction.Left:
                    x--;
                    break;
                case Direction.Right:
                    x++;
                    break;
                case Direction.Up:
                    y--;
                    break;
                case Direction.Down:
                    y++;
                    break;
            }

        }

    }
}
