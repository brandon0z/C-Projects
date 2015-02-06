using System;

namespace OnlineTutorialProgram
{
	class MainClass
	{
		public static void Main()
		{
			MainClass.EvenNumbers(30);

			MainClass P = new MainClass ();
			int Sum = P.Add(10, 20);

			Console.WriteLine("Sum = {0}", Sum);
		}

		public int Add(int FN, int SN)
		{
			return FN + SN;
		}

		public static void EvenNumbers(int Target)
		{
			int Start = 0;

			while (Start <= Target)
			{
				Console.WriteLine(Start);
				Start += 2;
			}
		}
	}

}
