
using System;
using System.Collections.Generic;

namespace src
{
//A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,

//a^2 + b^2 = c^2
//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.
	public class Problem9
	{
		public void Solve ()
		{
			int target = 1000;
			int answer = 0;
			int max = target / 2;
						
			while(answer == 0)
			{
				for(int m = 1; m < max; m++) {
           			for(int n = 1; n < m; n++) {
						//a = m²-n², b = 2mn, c = m² + n²
						int a = m*m - n*n;
						int b = 2*m*n;  
						int c = m*m + n*n;
						
						if(target % (a+b+c) == 0) {
		                   answer = a * b *c;
		               }
					}
				}
			}
			
			
			Console.WriteLine("Answer: " + answer);
		}
	}
}
