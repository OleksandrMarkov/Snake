﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_Snake
{
	public class Snake: Figure
	{
		public Snake_direction dir;
		
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
		
		internal bool is_hit_tail()
		{
			var head = point_list.Last();
			for (int i = 0; i < point_list.Count - 2; i ++)
			{
				if (head.is_hit(point_list[i]))
				{
					return true;
				}
			}
			return false;
		}
			 
		
		public void process_key(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
			{
				dir = Snake_direction.LEFT;
 			}
			else if (key == ConsoleKey.RightArrow)
			{
				dir = Snake_direction.RIGHT;
 			}
			else if (key == ConsoleKey.UpArrow)
			{
				dir = Snake_direction.UP;
 			}
			else if (key == ConsoleKey.DownArrow)
			{
				dir = Snake_direction.DOWN;
 			}
		}
		
		internal bool eat(Point food)
		{
			Point head = get_next_point();
			if(head.is_hit(food))
			{
				food.sym = head.sym;
				point_list.Add(food);
				return true;
			}
			else
				return false;
		}
	}
}
