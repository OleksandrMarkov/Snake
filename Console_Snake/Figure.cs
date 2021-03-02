using System;
using System.Collections.Generic;

namespace Console_Snake
{
	public class Figure
	{
		protected List <Point> point_list;
		
		public void display()
		{
			foreach(Point point in point_list)
			{
				point.display();
			}
		}
		
		public Figure()
		{
		}
	}
}
