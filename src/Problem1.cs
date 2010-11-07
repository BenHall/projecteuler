
using System;
using System.Collections.Generic;

namespace src
{
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.
	public class Problem1
	{

		public void Solve ()
		{
			int answer = 0;
			var foundNumbers = new List<int>();
			
			
			for (int i = 0; i < 1000; i++) {
				if(i % 3 == 0 || i % 5 == 0)
					foundNumbers.Add(i);
			}
			
			foreach (var item in foundNumbers) {
				Console.WriteLine(item);
				answer += item;
			}
			
			
			Console.WriteLine(answer);
		}
	}
}
