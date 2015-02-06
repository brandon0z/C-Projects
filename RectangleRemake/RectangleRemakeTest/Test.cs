using NUnit.Framework;
using System;
using RectangleRemake; 

namespace RectangleRemakeTest
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

			Assert.Contains("Hello There!", _output);
			Assert.Contains("Think of a rectangle. Now tell me the values of its length and width\" +\n\t\t\t\t\" and I'll calculate the area and perimeter of your unique rectangle: ", _output);
}

