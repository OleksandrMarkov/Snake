using System;

namespace Console_Snake
{
	public class Point
	{
		int x;
		int y; 
		char sym;
		
		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}
		
		public void display()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}
