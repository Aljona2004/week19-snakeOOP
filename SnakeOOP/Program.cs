using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');
            Point p2 = new Point(11, 10, '*');

            HorizontalLine hline = new HorizontalLine(10, 14, 5, '*');
            hline.Draw();
            VerticalLine vLine = new VerticalLine(6, 16, 10, '@');
            vLine.Draw();

            //drawing a game field frame
            HorizontalLine top = new HorizontalLine(0, 80, 0, '*');
            top.Draw();
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            left.Draw();
            HorizontalLine bottom = new HorizontalLine(0, 80, 25, '$');
            bottom.Draw();
            VerticalLine right = new VerticalLine(0, 25, 80, '$');
            right.Draw();
            

           Console.ReadLine();
        }

    }
}
