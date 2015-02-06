using System;

namespace DatatypesConverstion
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//float f = 123.45F;

			// explicit cast using typecast operator (int)
			//int i = (int)f;

			// explicit using Convert class
			//int i = Convert.ToInt32(f); 

			string strNumber = "100";

			int Result = 0;

			bool IsConversionSuccessful = int.TryParse(strNumber, out Result); 

			if(IsConversionSuccessful)
			{
				Console.WriteLine(Result);
			}
			else
			{
				Console.WriteLine("please enter a valid number.");
			}

		}
	}
}
