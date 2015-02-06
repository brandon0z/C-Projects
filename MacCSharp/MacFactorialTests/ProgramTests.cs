using NUnit.Framework;
using System.Collections.Generic;
using MacCSharp;

namespace MacFactorialTests
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

		[Test]
		public void TestWritesNumberAfterRead()
		{
			_input.Enqueue("5");
			_program.Run();

			Assert.Contains("The number you entered is: 5", _output);
		}

		[Test]
		public void TestWritesFactorialAfterRead()
		{
			_input.Enqueue("5");
			_program.Run();

			Assert.Contains("The factorial of 5 is: 120", _output);
		}

		[Test]
		public void TestWritesFactorialOneAfterRead()
		{
			_input.Enqueue("1");
			_program.Run();

			Assert.Contains("The factorial of 1 is: 1", _output);
		}

		[Test]
		public void TestWritesFactorialFourAfterRead()
		{
			_input.Enqueue("4");
			_program.Run();

			Assert.Contains("The factorial of 4 is: 24", _output);
		}

		[Test]
		public void TestWritesFactorialMinusFiveAfterRead()
		{
			_input.Enqueue("-5");
			_program.Run();

			Assert.Contains("The factorial of -5 is: 120", _output);
		}

		[Test]
		public void TestWritesFactorialNotANumberAfterRead()
		{
			_input.Enqueue("not a number");
			_program.Run();

			Assert.Contains("The value 'not a number' is not a whole integer and can't be used by this calculator.", _output);
		}

		[Test]
		public void TestWritesFactorialDecimalAfterRead()
		{
			_input.Enqueue("2.5");
			_program.Run();

			Assert.Contains("The value '2.5' is not a whole integer and can't be used by this calculator.", _output);
		}
	}

}

