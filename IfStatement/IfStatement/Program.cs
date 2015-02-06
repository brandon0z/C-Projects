using System;

namespace IfStatement
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("PLease enter a number");

			int UserNumber = int.Parse(Console.ReadLine());

			if(UserNumber == 10 || UserNumber == 20)
			{
				Console.WriteLine("Your number is 10 or 20");
			}
			else
			{

			}
		}
	}
}
