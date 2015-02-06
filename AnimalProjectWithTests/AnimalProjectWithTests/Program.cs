using System;

namespace AnimalProjectWithTests
{
	class MainClass
	{
		#region Test Infrastructure Code
		// This property contains a function to call to write to the console
		public Action<string> WriteLine { get; private set; }

		// This property contains a function to call to read a string from the console
		public Func<string> ReadLine { get; private set; }

		// Store the methods that perform the WriteLine and ReadLines to the console
		public MainClass(Action<string> writeLine, Func<string> readLine)
		{
			ReadLine = readLine;
			WriteLine = writeLine;
		}

		// Start the program by creating an instance of the program class and connecting it
		//   to the Console.ReadLine and Console.WiteLine methods.
		public static void Main(string[] args)
		{
			var program = new MainClass (Console.WriteLine, Console.ReadLine);
			program.Run();
		}
		#endregion

		#region Program Runs Here
		public void Run()
		{
			// Name of the application and asks the user for a number
			WriteLine("Welcome to my simple animal fact application.");
			WriteLine("Enter an animal type to hear something about your animal. ");

			// Reads the user input and sets it to a variable
			string userAnimal = ReadLine();

			// Compares the animal to pre-existing list 
			// NEED TO RUN computeAnimalSwitch HERE
			switch (userAnimal)
			{
			case "dog": 
				WriteLine("Dogs are mans best friend.");
				break;
			case "cat":
				WriteLine("15% - 30% of people are allergic to cats.");
				break;
			case "seal":
				WriteLine("Seals are not friendly.");
				break;
			default:
				WriteLine("Your animal is not supported, Please try again.");
				break;
			}
			ReadLine();
		}
		#endregion

		#region Attempt at method
//		var computeAnimalSwitch()
//		{
//			switch (userAnimal)
//			{
//			case "dog": 
//			WriteLine("Dogs are mans best friend.");
//			break;
//			case "cat":
//				WriteLine("15% - 30% of people are allergic to cats.");
//			break;
//			case "seal":
//				WriteLine("Seals are not friendly.");
//			break;
//			default:
//				WriteLine("Your animal is not supported, Please try again.");
//			break;
//			}
//			ReadLine();
//		}
		#endregion

			#region switch statement
//			switch (userAnimal)
//			{
//			case "dog": 
//				WriteLine("Dogs are mans best friend.");
//				break;
//			case "cat":
//				WriteLine("15% - 30% of people are allergic to cats.");
//				break;
//			case "seal":
//				WriteLine("Seals are not friendly.");
//				break;
//			default:
//				WriteLine("Your animal is not supported, Please try again.");
//				break;
//			}
//			ReadLine();
			#endregion


			#region if else statement
			//			if (userAnimal == "dog")
			//			{
			//				WriteLine("Dogs are mans best friend.");
			//			}
			//			else if (userAnimal == "cat")
			//			{
			//				WriteLine("15% - 30% of people are allergic to cats.");
			//			}
			//			else if (userAnimal == "seal")
			//			{
			//				WriteLine("Seals are not friendly.");
			//			}
			//			else WriteLine("Your animal is not supported, Please try again.");
			//
			//			ReadLine();
			#endregion
	}
}

