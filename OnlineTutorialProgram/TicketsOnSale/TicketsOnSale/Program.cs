using System;

namespace TicketsOnSale
{
	class MainClass
	{
		public static void Main()
		{
			int? TicketsOnSale = null;

			// Using Null Coalescing Operator ??
			int AvailableTickets = TicketsOnSale ?? 0;

			// Old Code replaced by null coalescing operator
//			if (TicketsOnSale == null)
//			{
//				AvailableTickets = 0;
//			}
//			else
//			{
//				AvailableTickets = (int)TicketsOnSale;
//			}

			Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
		}
	}
}
