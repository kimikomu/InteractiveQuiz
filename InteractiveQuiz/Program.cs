using System;

namespace InteractiveQuiz
{
	class Program
	{
		static void Main()
		{
			string[] states = { "California", "Hawaii", "Kentucky" };
			string[] answers = { "sacramento", "honolulu", "frankfort" };
			var answer = 0;
			var incorrect = 0;

			Console.WriteLine("State Capital Quiz");

			// ask all questions in the quiz one at a time
			foreach (string value in states)
			{
				Console.Write("What is the capital of " + value + "? ");
				var input = Console.ReadLine();

				// update the amount of incorrect answers
				if (input.ToLower() != answers[answer])
					incorrect += 1;

				// move to the next answer in the answers array
				answer++;
			}

			// print score
			if (incorrect == 0)
				Console.WriteLine("100%! You Win!");
			else if (incorrect == answers.Length)
				Console.WriteLine("NONE correct!? You lose!");
			else
				Console.WriteLine("You got " + incorrect + " questions wrong.");
			
			// prompt user to quit
			while (true)
			{
				Console.Write("GAME OVER...Enter \"q\" to quit: ");
				var q = Console.ReadLine();

				if (q.ToLower() == "q")
					break;
			}
		}
	}
}
