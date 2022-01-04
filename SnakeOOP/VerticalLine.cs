using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class VerticalLine
    {
        List<Point> pointList;

        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            pointList = new List<Point>();
            for(int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, symb);
                pointList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
