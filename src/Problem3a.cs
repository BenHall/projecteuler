
using System;
using System.Collections.Generic;
namespace src
{

//The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600851475143 ?
	
	public class Problem3a
	{
		public void Solve ()
		{
			long answer = 0;
			
			long target = 600851475143; //600851475143
			long max = target;
			long largest = 0;
			
			List<int> factors = PrimeFactors(target, 2);
	
			foreach (var item in factors) {
				if(item > answer)
					answer = item;
			}
			
						
			Console.WriteLine("Answer: " + answer);
		}
			
		
		public List<int> PrimeFactors(long target, int factor)
		{
			List<int> list = new List<int>();
			
			while(target % factor != 0) 
				factor = factor + 1;
			
			
			list.Add(factor);
				
			if(target > factor)
        			list.AddRange(PrimeFactors(target / factor, factor));

			return list;
		}
	}
}
