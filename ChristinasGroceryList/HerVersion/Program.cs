using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
	class Program
	{
		static void Main(string[] args)
		{
			//type [] arrayName = new type[arrayLength]
			String[] shop = new String[6];
			shop[0] = "Bread";
			shop[1] = "Cheese";
			shop[2] = "Milk";
			shop[3] = "Flour";
			shop[4] = "Apple juice";
			shop[5] = "";


			Console.WriteLine("Shopping foods list:");
			for (int i = 0; i < shop.Length; i++)
			{

				Console.WriteLine(shop[i]);

			}


			Console.WriteLine("Tell me another food to add to the list:");

			//add an item to index #5
			shop[5] = Console.ReadLine();

			Console.WriteLine("\nThe updated list is:");

			for (int i = 0; i < shop.Length; i++)
			{

				Console.WriteLine(shop[i]);

			}

			Console.ReadKey();
		}
	}
}
