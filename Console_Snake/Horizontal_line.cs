﻿using System;
using System.Collections.Generic;

namespace Console_Snake
{
	public class Horizontal_line : Figure
	{
		public Horizontal_line(int x_left, int x_right, int y, char sym)
		{
			point_list = new List<Point>();
			
			for (int x = x_left; x <= x_right; x++)
			{
				Point point = new Point(x, y, sym);
				point_list.Add(point);
			}
		}
	}
}
