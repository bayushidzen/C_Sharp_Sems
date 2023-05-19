using System;
namespace Snake
{
	public class FoodCreator
	{
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapW, int mapH,char food)
		{
			mapWidth = mapW;
			mapHeight = mapH;
			sym = food;
		}

        public Point CreateFood()
		{
			int x = random.Next(2, mapWidth - 2);
			int y = random.Next(2, mapHeight - 2);
			Point food = new Point(x, y, sym);
			return food;
		}
	}
}

