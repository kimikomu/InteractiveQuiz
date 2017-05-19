using System;

namespace InteractiveQuiz
{
	class Program
	{
		static void Main()
		{
			string[] questionTopics = { "California", "Hawaii", "Kentucky" };
			string[] answers = { "sacramento", "honolulu", "frankfort" };
			int correct = answers.Length;


			Console.WriteLine("State Capital Quiz");

			for (int i = 0, n = answers.Length; i < n; i++)
			{
				Console.Write("What is the capital of " + questionTopics[i] + "? ");

				string input = Console.ReadLine();

				if (input.ToLower() != answers[i])
				{
					correct -= 1;
				}
			}

			if (correct == 0)
				Console.WriteLine("NONE correct!? You lose!");
			else if (correct < answers.Length)
				Console.WriteLine("You got " + correct + " answers correct.");
			else if (correct == answers.Length)
				Console.WriteLine("100%! You Win!");
			else
				Console.WriteLine("Something is not working in this game.");

			while (true)
			{
				Console.Write("GAME OVER...Enter \"q\" to quit: ");
				string q = Console.ReadLine();

				if (q.ToLower() == "q")
				{
					break;
				}
			}

		}
	}
}
