using System;
using System.Collections.Generic;


namespace Assignment5Arrays
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

		// Define my initial groceries array
		public string[] groceries = new string[] { "Apples", "Bananas", "Oatmeal", "Peanut Butter", "" };

		// This is the actual program that runs.  It will have WriteLine and ReadLine properties
		//  from the class that allow it to write or read to the screen.
		public void Run()
		{
			WriteLine( "My Grocery List:" );

			// Writes each item in the array to console
			ListGroceries();

			WriteLine( "What would you like to add to the list?" );

			// Calls method to assign user input to the last item in array
			SetUserItem();

			WriteLine( "\nMy updated Grocery List:" );

			// Writes each item in the array to console
			ListGroceries();

			//ReadLine();

		}

		// Method to list items in the groceries array
		public void ListGroceries()
		{
			foreach ( string s in groceries )
			{
				WriteLine (s);
			}
		}

		// Method to read user input and add assign to variable
		void SetUserItem()
		{
			groceries [4] = ReadLine();

		}
	}
}
