using System;

namespace CalculateRectangleArea
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

			// Greets the user 
			WriteLine("Welcome to my application to calculate the area and perimeter of a rectangle.");
			WriteLine("To proceed I will need a few values from you.");

			// Asks for values, reads the iput and assigns to a value
			WriteLine("Please enter a length for our rectangle: ");
			userLength = Convert.ToDouble(Console.ReadLine()); 
			WriteLine("Please enter a Width for our rectangle: ");
			userWidth = Convert.ToDouble(Console.ReadLine());
			//String userWidth = ReadLine();

			int userWidthInteger = 0;
			int userLengthInteger = 0;

			if (int.TryParse(userWidth, out userWidthInteger))
			{
				someExpression;
			}
			if (int.TryParse(userLength, out userLengthInteger))
			{
				someExpression;
			}
			// Converts user input to integer values
			userLengthInteger = int.TryParse(userLength);
			userWidthInteger = int.TryParse(userWidth);
		}


		public int RectangleArea()
		{


			 
		}
	}
}

