using System;

namespace RectangleProject
{
	class MainClass
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

		public void Run()
		{
			WriteLine("Welcome to my Rectangle Program!");

			WriteLine("Enter the length of the rectangle: ");
			double lengthAsDouble = double.Parse(ReadLine());

			WriteLine("Enter the width of the rectangle: ");
			double widthAsDouble = double.Parse(ReadLine());

			var area = areaMethod(lengthAsDouble, widthAsDouble);
			var perimeter = perimeterMethod(lengthAsDouble, widthAsDouble);

			WriteLine("The area of your rectangle is {0}", area);

			WriteLine("The perimeter of your rectangle is {0}", perimeter);

		}
		static double areaMethod(double lengthAsDouble, double widthAsDouble)
		{
			double area = lengthAsDouble * widthAsDouble;
			return area;
		}

		static double perimeterMethod(double lengthAsDouble, double widthAsDouble)
		{
			double perimeter = (2 * lengthAsDouble) + (2 * widthAsDouble);
			return perimeter;
		}
	}
}
