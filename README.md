#

<br>

#  Portfolio
### Tools & Technology 
Hello, I am an aspiring developer interested in future developing my skills in C# and eventually learning other languages. This project is designed to highlight tools and concepts that I'm exploring and continuing to familiarize myself with. This project is also displaying the concepts that I learned throughout the time I attended Fullsail University in a form of an application that I'm currently working on called "Triplists". This App will allow the user to keep track of expenses spent on a trip. 


##Code Exploration:

At the beginning of this program, the user will be taken to this screen called the program class. This is the initial entry point of a program that lets the user know what the application is about. 



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
At the beginning of this program, the user will be taken to this screen called the program class. This is the initial entry point of a program that lets the user know what the application is about. 


It will be displayed something like this :
Next, a user will be taken to the screen where the features of the menu are being displayed 
In this case, the menu option will loop using a for loop 

For Loop is a loop that we use if we know how many times that block of code will loop.
So here is an example of a Menu class using a for loop in my trip list app. In this case, this will display how many times will we loop all menu options. Example Code Here 
```c#
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

So now we are going to be talking about validation. Some validation methods that we used were: Validate integer, and user input using the null or empty method. So when they enter their username to create an account, they will use the null and empty methods. This validates that the person will not leave this answer blank and must be answered if the wants to move on to the next question. 

 Example code :

```c#


Console.Write("UserName: ");
			string userName = Console.ReadLine();
			userName = Validation.ValidateString(userName);





```

While Loop- is a loop that we use if we don't know how many will run. In this case, this loop will run as long as the user keeps this answer blank.
    Example code :
  
  ```C#
                  


public static string ValidateString(string input)
        {
            bool isValid = false;
            while(!isValid)
            {
                if (!string.IsNullOrEmpty(input))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid input. Try again ");
                    input = Console.ReadLine();
                }
            }
  ```
  Next, another validation method that I worked with was the Integer validation method. So this will also be displayed when we validate that a numerical value is entered correctly. In this case, we will use this validation method to validate their id number          
  Example here: 
 
 ```c#
 
 
 Console.Clear();
			Console.Write("ID: ");
			string id = Console.ReadLine();
			int validatedId = Validation.ValidateInteger(id);

 
 
 
 
 
 ```
 So it will be validate using this method as follows
 
 Example here:
 
 ```
   
  public static int ValidateInteger(string input)
        {
            bool isValid = false;
            int result = 0;
            while (!isValid)
            {
                if (int.TryParse(input, out result))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid input. Try again ");
                    input = Console.ReadLine();
                }
            } 
            
            
            
            
            
            
 ``` 
  
 So now when the app asks the users to enter a password, that can be validated using a Regex test. This means that their password has to meet the requirements to move on. 

  Example will be : 
  ```c#
  
  
    
    Console.Write("Password: ");
			string password = Console.ReadLine();
			password = Validation.ValidateString(password)    
  
Then when the user wants to validate that met the requirements for the password, they would use this validation method


```c#



 public static string ValidateRegex(string input, string pattern)
        {
            Regex rg = new Regex(pattern);
            bool isvalid = false;
            while (!isvalid)
            {
                if (rg.IsMatch(input))
                {
                    isvalid = true;

                }
                else
                {
                    Console.WriteLine($"Invalid input.Should match the pattern :{pattern}.Try again ");
                    input = Console.ReadLine();
                }
            }
            return input;
        }
    }

}






```
 So if the user wants to change their password because they have forgotten it or they just want to update their password. So these conditions will allow them three attempts to login in with their current password or they have to create a new password. 

```c#


public void ChangePassword()
		{
			Console.Clear();
			Console.WriteLine("Enter Current Password:");
			string password = Console.ReadLine();
			int retries = 0;
			bool passWordMatch = false;
			while (retries < 3 && passWordMatch == false)
			{
				if (_activeUser.Password == password)
				{
					passWordMatch = true;
				}
				else
				{
					Console.WriteLine("Enter current Password:");
					password = Console.ReadLine();
					retries += 1;

				}
			}
			if (passWordMatch == false)
			{
				Console.WriteLine(" Max attempts exceeded.");

			}
			else
			{
				Console.Write("Enter a new Password:");
				var newPassword = Console.ReadLine();
				newPassword = Validation.ValidateRegex(newPassword, "(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\\W)");
				_activeUser.Password = newPassword;
			}





```

##My Contact Info         
[GitHub Account] (https://github.com/Motleykm/Portfolio)

[Linkedin](https://www.linkedin.com/in/kamirah-motley-/)          
   
