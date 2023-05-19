using System;
namespace Snake
{
	class VerticalLine : Figure
	{
        public VerticalLine(int x, int yTop, int yDawn, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i < yDawn; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }

        }

    }
}

