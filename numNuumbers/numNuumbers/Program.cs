using System;

namespace numNuumbers
{
	class Program
	{
		static int SumNumbers(int numNumbers)
		{
			int sum = 0;
			for (int i = 1; i <= numNumbers; i++)
			{
				Console.Write("Enter number " + i + ": ");
				//Console.ReadLine();
				sum += int.Parse(Console.ReadLine());
			}
			return sum;
		}

		static void Main(string[] args)
		{

			//Display the title
			Console.WriteLine("Let's calculate the sum of numbers you entered");

			//Collect the numbers
			Console.WriteLine("How many numbers will we calculate?");

			int numNumbers = int.Parse(Console.ReadLine());

			var sum = SumNumbers(numNumbers);


			Console.WriteLine("The sum of the numbers you entered is: " + sum);
			Console.ReadLine();
		}
	}
}