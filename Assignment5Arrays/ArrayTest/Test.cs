using NUnit.Framework;
using System.Collections.Generic;
using Assignment5Arrays;

namespace ArrayTest
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
		public void TestWritesInitialGroceryList()
		{
			//_input.Enqueue("5");
			_program.Run();

			Assert.Contains("My Grocery List:", _output);

		}

		[Test]
		public void TestUserItemAddedToArray()
		{
			_input.Enqueue("Beer");
			_program.Run();

			// Assert that Beer is added to the groceryList array
			Assert.Contains("The number you entered is: 5", _output);

		}
		[Test]
		public void TestUserItemAddedToArray()
		{
			_input.Enqueue("445");
			_program.Run();

		//Assert.Contains("The number you entered is: 5", _output);
		// Test to handle errors (integer input)
		}