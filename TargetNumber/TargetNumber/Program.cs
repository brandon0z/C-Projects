using System;

namespace TargetNumber
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter your target");

			int UserTarget = int.Parse(Console.ReadLine());

			int start = 0;

			while(start <= UserTarget)
			{
				Console.Write(start + " ");
				start += 2;
			}
		}
	}
}
