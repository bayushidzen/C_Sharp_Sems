using System;
namespace Snake
{
	public class Figure
	{
        protected List<Point> pList;

        public void DrawFigure()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

