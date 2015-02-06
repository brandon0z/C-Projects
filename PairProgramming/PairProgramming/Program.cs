using System;


namespace PairProgramming
{
	public class MainClass
	{
		#region Test Infrastructure Code
		// This property contains a function to call to write to the console
		public Action<string> WriteLine { get; private set; }

		// This property contains a function to call to read a string from the console
		public Func<string> ReadLine { get; private set; }

		// Store the methods that perform the WriteLine and ReadLines to the console
		public MainClass(Action<string> writeLine, Func<string> readLine)
		{
			ReadLine = readLine;
			WriteLine = writeLine;
		}

		// Start the program by creating an instance of the program class and connecting it
		//   to the Console.ReadLine and Console.WiteLine methods.
		public static void Main(string[] args)
		{
			var program = new MainClass (Console.WriteLine, Console.ReadLine);
			program.Run();
		}
		#endregion

		// This is the actual program that runs.  It will have WriteLine and ReadLine properties
		//  from the class that allow it to write or read to the screen.

		// Initializes the Toys Array
		public string[] Toys = { "Doll", "Hummingbird", "Ballerina", "Car", "Airplane" };

		// Runs the program
		public void Run()
		{
			WriteLine("This is my miniature collection");
			WriteLine("");
			ListToys();
			WriteLine("");
			WriteLine("What item do you like the best(select by the item number): ");
			int userChoice;
			if (int.TryParse(ReadLine(), out userChoice))
			{
				ChoiceOfUser(userChoice);
			}
			else
			{
				Console.WriteLine("Please enter 1, 2, 3, 4 or 5");
			}
		}

		// Method to write the numbered Toys array
		void ListToys()
		{
			for (int i = 0; i < Toys.Length; i++)
			{
				WriteLine(i + 1 + ". " + Toys[i]);
			}
		}
		// Method to calculate output based on userChoice input
		void ChoiceOfUser(int userChoice)
		{
			//I want to change this but am not sure how ?? //if(new []{1, 2, 3}.Contains(x))
			if (userChoice == 1 || userChoice == 2 || userChoice == 4 || userChoice == 5)
			
			{
				WriteLine("You like the " + Toys [userChoice - 1] + " the best");
				WriteLine("I think the " + Toys [3] + " is the greatest of them all.");
			}
			else if (userChoice == 3)
			{
				WriteLine("We both like the Ballerina! Isn't she the Cutest!!");
			}
			else
			{
				WriteLine("You have entered an incorrect value, please enter a whole number between 1 and 5.");
			}
		}

	}
}
