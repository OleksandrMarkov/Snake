﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Snake
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);
			Console.SetBufferSize(80, 25);
			
			char border_sign = '*';
			
			// Field borders
			Horizontal_line upper_border = new Horizontal_line(0, 78, 0, border_sign);
			Horizontal_line bottom_border = new Horizontal_line(0, 78, 24, border_sign);
			Vertical_line left_border = new Vertical_line(0, 0, 24, border_sign);
			Vertical_line right_border = new Vertical_line(78, 0, 24, border_sign);
			
			upper_border.display();
			bottom_border.display();
			left_border.display();
			right_border.display();
			
			Point p = new Point(2, 3, '#');
			Snake snake = new Snake(p, 4, Snake_direction.RIGHT);
			snake.display();
			
			Food_creator food_creator = new Food_creator (80, 25, '$');
			Point food = food_creator.create_food();
			food.display();
			
			while(true)
			{
				if (snake.eat(food))
				{
					food = food_creator.create_food();
					food.display();
				}
				else
				{
					snake.move();
				}
				
				Thread.Sleep(100);
				
				if(Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.process_key(key.Key);
				}
				
			}
			
		}
	}
}