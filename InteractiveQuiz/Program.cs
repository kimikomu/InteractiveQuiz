using System;

namespace InteractiveQuiz
{
	class Program
	{
		static void Main()
		{
			string[] states = { "California", "Hawaii", "Kentucky" };
			string[] answers = { "sacramento", "honolulu", "frankfort" };
			int correct = answers.Length;
			int i = 0;

			Console.WriteLine("State Capital Quiz");

			
			foreach (string value in states)
			{
				Console.Write("What is the capital of " + value + "? ");
				string input = Console.ReadLine();

				if (input.ToLower() != answers[i])
					correct -= 1;

				i++;
			}

			if (correct == 0)
				Console.WriteLine("NONE correct!? You lose!");
			else if (correct == answers.Length)
				Console.WriteLine("100%! You Win!");
			else
				Console.WriteLine("You got " + correct + " answers correct.");
			
			while (true)
			{
				Console.Write("GAME OVER...Enter \"q\" to quit: ");
				string q = Console.ReadLine();

				if (q.ToLower() == "q")
					break;
			}
		}
	}
}
