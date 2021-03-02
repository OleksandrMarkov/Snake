using System;
using System.Collections.Generic;

namespace Console_Snake
{
	public class Snake: Figure
	{
		
		public Snake(Point tail, int length, Snake_direction direction)
		{
			point_list = new List <Point>();
			for(int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.move(i, direction);
				point_list.Add(p);
			}
		}
	}
}
