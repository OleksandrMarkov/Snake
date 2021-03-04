using System;

namespace Console_Snake
{
	public class Food_creator
	{
		int map_width, map_height;
		char sym;
		
		Random random = new Random();
		
		public Food_creator(int map_width, int map_height, char sym)
		{
			this.map_width = map_width;
			this.map_height = map_height;
			this.sym = sym;
		}
		
		public Point create_food()
		{
			int X = random.Next(2, map_width - 2);
			int Y = random.Next(2, map_height - 2);
			
			return new Point (X, Y, sym);
		}
	}
}
