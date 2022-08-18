using System;
using System.Collections.Generic;
//Motley,Kamirah
//08/17/2022
//Course :Portfolio 1 Fundamentials of Application Development
//Synopsis :Application for people to keep track of their expenses based on their trip and area prices 

namespace TripLists
{
	public class Menu
	{
		
		private string _title;
		private List<string> _menuItems;
		  public Menu()
		{
		}
		public void Init(string title, List<string> menuItems)
        {
			_title = title;
			_menuItems = menuItems;
        }
		//gives the program its unique color
		public void Display()
        {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("**********************");
			Console.WriteLine(_title);
			Console.WriteLine("*********************");
			Console.WriteLine();
			///loop through the menu options upon user input
             for(int i= 0; i< _menuItems.Count; i++)
            {
				if(_menuItems[i]== "Exit")
                {
					Console.WriteLine();
					Console.WriteLine("[0]" + _menuItems[i]);
					Console.WriteLine();
					Console.WriteLine("------------------------");


                }
				else
                {
					Console.WriteLine($"[{i + 1}] {_menuItems[i]}");

                }

            }
        }
	}
}

