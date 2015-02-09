using System;

namespace ChristinasGroceryList
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			String[] shopList = new string[6];
			shopList [0] = "Bread";
			shopList [1] = "Cheese";
			shopList [2] = "Milk";
			shopList [3] = "Flour";
			shopList [4] = "Juice";
			shopList [5] = "";

			Console.WriteLine( "Shopping food list:" );
			for (int i = 0; i < shopList.Length; i++)
			{
				Console.Write(shopList[i]);
			}

			Console.WriteLine( "Give me a food item to add to the list" )

			shopList[5] = Console.ReadLine();

			for ( int i = 0; i < shopList.Length; i++ )
			{
				Console.WriteLine(shopList[i]);
			}

			Console.ReadKey();
		}
	}
}
