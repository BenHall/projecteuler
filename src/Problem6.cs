
using System;
using System.Collections.Generic;

namespace src
{
//The sum of the squares of the first ten natural numbers is,

//12 + 22 + ... + 102 = 385
//The square of the sum of the first ten natural numbers is,

//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.

//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
	public class Problem6
	{
		public void Solve ()
		{
			int target = 100;
			int answer = 0;	
			
			int sumOfSquares = 0;
			int sum = 0;
			
			for (int i = 0; i <= target; i++) {
				sumOfSquares += i * i;
				sum += i;
			}
			
			int squareOfSum = sum * sum;
			
			answer = squareOfSum - sumOfSquares;
			
			Console.WriteLine("Answer: " + answer);
		}
	}
}
