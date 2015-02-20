using System;

namespace AnotherClassProject02092015
{
	class Mainclass
	{
		public static void CalculateTotal() // static makes it belong to the class, not the object of the class
		{
			Console.WriteLine( "Lets calculate the sum of three numbers!" );


			// ask stani how to ask for all three inputs together
			int num1 = GetInt ( "Enter the first number" );
			int num2 = GetInt ( "Enter the second number" );
			int num3 = GetInt ( "Enter the third number" );

			int answer = GetTotal ( num1, num2, num3 );

			Console.WriteLine( "The total sum is: " + answer );
			Console.ReadLine();
		}

		public static int GetTotal( int firstNum, int secondNum, int thirdNum )
		{
			int sum = firstNum + secondNum + thirdNum;

			return sum;
		}

		public static int GetInt ( String prompt )
		{
			Console.Write( prompt + ":" );
			int num = int.Parse( Console.ReadLine() );

			return num;
		}

		static void Main( string[] args )
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Blue;

			//Mainclass MathProgram = new Mainclass (); // removed this when we added the static keyword
			Mainclass.CalculateTotal();
		}
	}
}


// private means you cannot call it from another class - Access modifier
// static methods belong to the class