using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.left)
            {
                x = x - offset;
            }
            else if(direction == Direction.up)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }

    }
}
