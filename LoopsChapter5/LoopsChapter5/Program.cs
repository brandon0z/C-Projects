using System;

namespace LoopsChapter5
{
	class MainClass
	{
		public static void Main()
		{
			int i = 1, sum = 0;
			while (i < 5)
			{
				sum += 1;
				i++;
				Console.WriteLine("sum equals " + sum);
				Console.WriteLine("i equals " + i);
			}
		}
	}
}
