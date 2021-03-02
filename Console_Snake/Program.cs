﻿using System;
using System.Collections.Generic;

namespace Console_Snake
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);
			Console.SetBufferSize(80, 25);
			
			char border_sign = '*';
			
			Horizontal_line upper_border = new Horizontal_line(0, 78, 0, border_sign);
			Horizontal_line bottom_border = new Horizontal_line(0, 78, 24, border_sign);
			Vertical_line left_border = new Vertical_line(0, 0, 24, border_sign);
			Vertical_line right_border = new Vertical_line(78, 0, 24, border_sign);
			
			upper_border.display();
			bottom_border.display();
			left_border.display();
			right_border.display();
			
			Console.ReadKey(true);
		}
	}
}