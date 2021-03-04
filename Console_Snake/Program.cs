using System;
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
			
			Borders borders = new Borders(80,25);
			borders.display();
			
			Point p = new Point(2, 3, '#');
			Snake snake = new Snake(p, 4, Snake_direction.RIGHT);
			snake.display();
			
			Food_creator food_creator = new Food_creator (80, 25, '$');
			Point food = food_creator.create_food();
			food.display();
			
			while(true)
			{
				if(borders.is_hit(snake) || snake.is_hit_tail())
				{
					break;
				}
				
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