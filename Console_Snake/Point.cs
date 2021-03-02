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
		
		public Point (Point p)
		{
			this.x = p.x;
			this.y = p.y;
			this.sym = p.sym;
		}
		
		public void move(int offset, Snake_direction s_dir)
		{
			if (s_dir == Snake_direction.RIGHT)
			{
				this.x += offset;
			}
			else if (s_dir == Snake_direction.LEFT)
			{
				this.x -= offset;
			}
			else if (s_dir == Snake_direction.DOWN)
			{
				this.y += offset;
			}
			else if (s_dir == Snake_direction.UP)
			{
				this.y -= offset;
			}
		}
		
		public void clear()
		{
			this.sym = ' ';
			display();
		}
		
		public void display()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}
