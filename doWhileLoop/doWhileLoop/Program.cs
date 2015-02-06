using System;

namespace doWhileLoop
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string UserChoice = string.Empty;
			do
			{

				Console.WriteLine("Please enter your target");
				int UserTarget = int.Parse(Console.ReadLine());

				int start = 0;

				while (start <= UserTarget)
				{
					Console.Write(start + " ");
					start += 2;
				}
				

				do
				{
					Console.WriteLine("Do you want to continue - yes or no?");

					UserChoice = Console.ReadLine().ToLower();
					if (UserChoice != "yes" && UserChoice != "no")
					{
						Console.WriteLine("Invalid Choice. Please say yes or no");
					}
				} while(UserChoice != "yes" && UserChoice != "no");
			} while(UserChoice == "yes");
		}
	}
}
