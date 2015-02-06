using NUnit.Framework;
using System.Collections.Generic;
using PairProgramming;

// In object-oriented programming, the dependency inversion principle refers to a specific form of decoupling software modules.
// In software engineering, dependency injection is a software design pattern that implements inversion of control for software 
//  libraries, where the caller delegates to an external framework the control flow of discovering and importing a service or software module.

namespace PairProgrammingTests
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
			return _input.Count != 0 ? _input.Dequeue() : string.Empty;

		}
//		string MockReadLine()
//		{
//			if (_input.Count != 0)
//				return _input.Dequeue();
//
//			return string.Empty;
//		}

		[Test]
		public void TestWritesWelcome()
		{
			_program.Run();

			Assert.Contains("This is my miniature collection", _output);
		}

		[Test]
		public void UserEnters1()
		{
			_input.Enqueue("1");
			_program.Run();

			Assert.Contains("You like the Doll the best", _output);
		}

		[Test]
		public void UserEnters2()
		{
			_input.Enqueue("2");
			_program.Run();

			Assert.Contains("You like the Hummingbird the best", _output);
		}

		[Test]
		public void UserEnters3()
		{
			_input.Enqueue("3");
			_program.Run();

			Assert.Contains("We both like the Ballerina! Isn't she the Cutest!!", _output);
		}

		[Test]
		public void UserEnters4()
		{
			_input.Enqueue("4");
			_program.Run();

			Assert.Contains("You like the Car the best", _output);
		}

		[Test]
		public void UserEnters5()
		{
			_input.Enqueue("5");
			_program.Run();

			Assert.Contains("You like the Airplane the best", _output);
		}

		[Test]
		public void UserEnters6()
		{
			_input.Enqueue("6");
			_program.Run();

			Assert.Contains("You have entered an incorrect value, please enter a whole number between 1 and 5.", _output);
		}

		// Test if user enters a non integer
	}
}