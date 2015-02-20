using System;

namespace MoreClassProject02092015
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// declare 2d array with numbers ;

			int[,] array2Da = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

			// print out elements
			Console.WriteLine( array2Da [0,0] );
			Console.WriteLine( array2Da [0,1] );
			Console.WriteLine( array2Da [1,0] );

			Console.ReadLine();
		}
	}
}
