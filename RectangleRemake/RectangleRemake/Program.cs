using System;

namespace RectangleRemake
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
			WriteLine("Hello There!");
			WriteLine("Think of a rectangle. Now tell me the values of its length and width" +
				" and I'll calculate the area and perimeter of your unique rectangle: ");
		}
	}
}
