using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;

namespace rickSum
{
	interface IConsole
	{
		void Write(string text);
		void WriteLine(string test);
		string ReadLine();
	}

	interface ISummarizer
	{
		double Sum(params double[] numbers);
	}

	class DefaultConsole : IConsole
	{
		#region IConsole implementation

		public void Write(string text)
		{
			Console.Write(text);
		}

		public void WriteLine(string text)
		{
			Console.WriteLine(text);
		}

		public string ReadLine()
		{
			return Console.ReadLine();
		}

		#endregion
	}

	class DefaultSummarizer : ISummarizer
	{
		#region ISummarizer implementation

		public double Sum(params double[] numbers)
		{
			return numbers.Sum();
		}

		#endregion
	}

	class MainClass
	{
//		#region Test Infrastructure Code
//		// This property contains a function to call to write to the console
//		public Action<string> WriteLine { get; private set; }
//
//		// This property contains a function to call to read a string from the console
//		public Func<string> ReadLine { get; private set; }
//
//		// Store the methods that perform the WriteLine and ReadLines to the console
//		public MainClass(Action<string> writeLine, Func<string> readLine)
//		{
//			ReadLine = readLine;
//			WriteLine = writeLine;
//		}
//		#endregion

		public static void Main(string[] args)
		{
			var container = new UnityContainer ();

			container.RegisterInstance<IConsole>(new DefaultConsole());
			container.RegisterType<ISummarizer, DefaultSummarizer>();

			var program = container.Resolve<MainClass>();

			program.Run();

			container.Dispose();
		}

		[Dependency]
		public ISummarizer Summarizer { get; set; }

		[Dependency]
		public IConsole CurrentConsole { get; set; }

		public void Run()
		{
			var numbersToSum = new List<double> ();

			CurrentConsole.WriteLine("Please enter numbers you want me to add.  When you have finished just enter 'done'.");

			while(true) {
				CurrentConsole.Write("Enter a number or type 'done': ");
				var inputString = Console.ReadLine();

				var inputNumber = 0.0;
				if (double.TryParse(inputString, out inputNumber))
				{
					numbersToSum.Add(inputNumber);
				}
				else
				{
					if (inputString.ToLowerInvariant() == "done")
					{
						break;
					}
					CurrentConsole.WriteLine(string.Format("I'm sorry, '{0}' is not a number or the word done.", inputString));
				}
			}

			var sum = Summarizer.Sum(numbersToSum.ToArray());

			CurrentConsole.WriteLine(string.Format("The sum of the numbers {0} is {1}", string.Join(", ", numbersToSum.Select(n => n.ToString())), sum));
		}
	}
}
