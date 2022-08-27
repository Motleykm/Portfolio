# 
  #  Portfolio
 ### Tools & Technology 
 Hello , I am aspiring developer interested in future developing my skills in C# and eventually learn other languages.This project is designed to highlight tools and concepts that Im exploring and continuing to familiarize myself about.This project is also displaying the concepts that I learned throughout the time I attended Fullsail University in a form of application that Im currently working on called "Triplists". This App will allow the user to keep track of expenses spent on a trip. 

 
 
  ##Code Exploration:

  This link will take you to the concepts and notes and work in progress related to my ongoing project completion.

  At the begining of this program , the user will be taken to this screen called the program class.This is the initial entry point of the   of a program  that lets the user know what is the application is about. 

 
  It will be displayed something like this :

  Exmaple Code Here

 
 
  ```c#
 namespace TripLists
 {
     class Program
     {//entry point to the program 
         public static void Main(string[] args)
         {
             Console.WriteLine("Welcome to the Triplists App.. where you can track all trip expenses");
             var project = new App();

         }
 ```
```
Next a user will be taken to the screen where the features of the menu are being displayed 
In this case the menu option will loop using a foreeach loop 

For Loop is a loop that we use if we know how many times that block of code will loop.
So here is a example of Menu class usng a for loop in my triplist app .In this case this  will diplay how many times will we loop all menu options.
 
 Example Code Here 
 
 ```C#
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

 
 
 
 
 
 
 
 
 
 
 
 
 
  42  
README.md
  

 
Load diff
