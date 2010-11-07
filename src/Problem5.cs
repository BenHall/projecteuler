
using System;
using System.Collections.Generic;

namespace src
{
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	public class Problem5
	{
		public void Solve ()
		{
			int answer = 0;
			int input = 1;
			
			int max = 20;
			while(answer == 0)
			{
				bool all = true;
				for (int i = max; 0 < i; i--) {
					if(input % i != 0) {
						all = false;
						break;
					}
				}
				
				if(all)
				{
					answer = input;
					break;
				}
				
				input++;
			}		
						
			Console.WriteLine("Answer: " + answer);
		}
	}
}
