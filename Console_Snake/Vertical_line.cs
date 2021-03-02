using System;
using System.Collections.Generic;

namespace Console_Snake
{
	public class Vertical_line
	{
		List <Point> point_list;
		
		public Vertical_line(int x, int y_top, int y_bottom, char sym)
		{
			point_list = new List<Point>();
			
			for (int y = y_top; y <= y_bottom; y++)
			{
				Point point = new Point(x, y, sym);
				point_list.Add(point);
			}	
		}
		
		public void display()
		{
			foreach(Point point in point_list)
			{
				point.display();
			}
		}
	}
}
