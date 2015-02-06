using NUnit.Framework;
using System;

namespace rickSumTest
{
	[TestFixture]
	public class ProgramTests
	{
		MainClass _program;
		List<string> _output;
		Queue<string> _input;

		[SetUp]
		public void ProgramTestsSetup()
		{
			_output = new List<string>();
			_input = new Queue<string> ();
			_program = new MainClass (MockWriteLine, MockReadLine);
		}

		void MockWriteLine(string line)
		{
			_output.Add(line);
		}

		string MockReadLine()
		{
			return _input.Dequeue();
		}

		[Test]
		public void TestWritesWelcome()
		{
			_input.Enqueue("5");
			_program.Run();

			Assert.Contains("Factorial Calculator!", _output);
			Assert.Contains("Please enter a number and I will tell you its factorial ", _output);

		}

}

