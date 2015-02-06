using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPrice
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name? ");
			string userName = Console.ReadLine();

			Console.WriteLine(userName + ", what is your meal total?");
			double mealPrice = double.Parse(Console.ReadLine());
			double totalBill = CalculateTax(mealPrice);

			// round value to two decimal places

			totalBill = Math.Round(totalBill, 2);
			Console.WriteLine("Your total is: $" + totalBill);

			Console.Read();

		}

		public static double CalculateTax(double mealPrice)
		{

			// calculate meal tax
			double result = mealPrice + (mealPrice * 0.1);
			return result;
		}
	}
}

