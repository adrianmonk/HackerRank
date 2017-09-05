using System;
using System.Collections.Generic;

namespace HackerRankChallenges
{
	public class MinMaxSum
	{
		public MinMaxSum()
		{
			var numbers = GetInput();

			Int64 min = 0;
			for (int i = 0; i < 4; i++) min += numbers[i];

			Int64 max = 0;
			for (int i = 1; i < 5; i++) max += numbers[i];

			Console.Write(min + " " + max);

		}

		public List<long> GetInput()
		{
			//List<Int64> input;
			string[] input = Console.ReadLine().Split(' ');
			List<long> numbers = new List<long>();

			foreach (string number in input)
			{
				numbers.Add(Convert.ToInt64(number));
			}
			
			numbers.Sort();

			return numbers;
		}
	}
}
