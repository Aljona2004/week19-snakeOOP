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

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

    }
}
