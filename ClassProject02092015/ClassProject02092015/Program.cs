using System;

namespace ClassProject02092015
{
	class Mainclass
	{
		public int Add() // THIS IS THE METHOD SIGNATURE
		{
			Console.WriteLine("Enter first number: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter your second number: ");
			int num2 = int.Parse(Console.ReadLine());

			int result = num1 + num2;

			return result;
		}
		static void Main(string[] args)
		{
			Mainclass MathProgram = new Mainclass ();
			Console.WriteLine("Result is: " + MathProgram.Add());
			Console.ReadLine();
		}
	}
}
