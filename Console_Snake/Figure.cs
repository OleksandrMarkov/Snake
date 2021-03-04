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
		
		internal bool is_hit(Figure figure)
		{
			foreach (var p in point_list)
			{
				if(figure.is_hit(p))
				{
					return true;
				}
			}
			return false;
		}
		
		private bool is_hit(Point point)
		{
			foreach(var p in point_list)
			{
				if(p.is_hit(point))
				{
					return true;
				}
			}
			return false;
		}
	}
}
