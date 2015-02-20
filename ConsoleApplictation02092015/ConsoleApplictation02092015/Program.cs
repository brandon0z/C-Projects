using System;

namespace ConsoleApplictation02092015
{
	class MainClass
	{
		public void CalculateTotal()
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

		public int GetTotal( int firstNum, int secondNum, int thirdNum )
		{
			int sum = firstNum + secondNum + thirdNum;

			return sum;
		}

		public int GetInt ( String prompt )
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

			MainClass MathProgram = new MainClass ();
			MathProgram.CalculateTotal();
		}
	}
}
