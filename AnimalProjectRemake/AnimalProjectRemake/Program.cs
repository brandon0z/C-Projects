using System;

namespace AnimalProjectRemake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to my simple animal fact application.");
			Console.WriteLine("Enter an animal type to hear something about your animal.");

			// Accepts input from user
			string userAnimal = Console.ReadLine();


			#region switch statement
			switch (userAnimal)
			{
			case "dog": 
				Console.WriteLine("Dogs are mans best friend.");
				break;
			case "cat":
				Console.WriteLine("15% - 30% of people are allergic to cats.");
				break;
			case "seal":
				Console.WriteLine("Seals are not friendly.");
				break;
			default:
				Console.WriteLine("Your animal is not supported, Please try again.");
				break;
			}
			Console.ReadLine();
			#endregion


			#region if else statement
//			if (userAnimal == "dog")
//			{
//				Console.WriteLine("Dogs are mans best friend.");
//			}
//			else if (userAnimal == "cat")
//			{
//				Console.WriteLine("15% - 30% of people are allergic to cats.");
//			}
//			else if (userAnimal == "seal")
//			{
//				Console.WriteLine("Seals are not friendly.");
//			}
//			else Console.WriteLine("Your animal is not supported, Please try again.");
//
//			Console.ReadLine();
			#endregion
		}

	}
}
