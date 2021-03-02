using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_Snake
{
	public class Snake: Figure
	{
		Snake_direction dir;
		
		public Snake(Point tail, int length, Snake_direction dir)
		{
			this.dir = dir;
			
			point_list = new List <Point>();
			for(int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.move(i, dir);
				point_list.Add(p);
			}
		}
		
		internal void move()
		{
			Point tail = point_list.First();
			point_list.Remove(tail);
			Point head = get_next_point();
			
			point_list.Add(head);
			
			tail.clear();
			
			head.display();	
		}
		
		public Point get_next_point()
		{
			Point head = point_list.Last();
			Point next = new Point(head);
			next.move(1, dir);
			return next;
		}
	}
}
