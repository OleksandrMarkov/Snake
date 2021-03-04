using System;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Console_Snake
{	
	public class Borders
	{
		List <Figure> borders_list;
		const char border_sign = '*';
		
		public Borders(int map_width, int map_height)
		{
			borders_list = new List<Figure>();
			
			Horizontal_line upper_border = new Horizontal_line(0, map_width - 2, 0, border_sign);
			Horizontal_line bottom_border = new Horizontal_line(0, map_width -2, map_height - 1, border_sign);
			Vertical_line left_border = new Vertical_line(0, 0, map_height- 1, border_sign);
			Vertical_line right_border = new Vertical_line(map_width - 2, 0, map_height - 1, border_sign);
			
			borders_list.Add(upper_border);
			borders_list.Add(bottom_border);
			borders_list.Add(left_border);		
			borders_list.Add(right_border);						
		}
		
		internal bool is_hit(Figure figure)
		{
			foreach (var border in borders_list)
			{
				if (border.is_hit(figure))
				{
					return true;
				}
			}
			return false;
		}
		
		public void display()
		{
			foreach (var border in borders_list)
			{
				border.display();
			}
		}
	}
}