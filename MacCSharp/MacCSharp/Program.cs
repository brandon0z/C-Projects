﻿using System;

namespace MacCSharp
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
		public void Run()
		{
			// Name of the application and asks the user for a number
			WriteLine("Factorial Calculator!");
			WriteLine("Please enter a number and I will tell you its factorial ");

			// Reads the user input and sets it to a variable
			String userString = ReadLine();

			// Converts the user input to an integer and sets it to a new variable
			int userInteger = 0;
			if (int.TryParse(userString, out userInteger))
			{
				int fac = Factorial(userInteger);

				WriteLine(string.Format("The number you entered is: {0}", userInteger));
				WriteLine(string.Format("The factorial of {0} is: {1}", userInteger, fac));
			}
			else 
			{
				WriteLine(string.Format("The value '{0}' is not a whole integer and can't be used by this calculator.", userString));
			}
		}

		// This is the function that computes the factorial
		public int Factorial(int fac)
		{
			fac = Math.Abs(fac);
			return ((fac == 1) ? 1 : fac * Factorial(fac - 1));  


		}
	}
}