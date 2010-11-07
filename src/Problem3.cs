
using System;
using System.Collections.Generic;

namespace src
{

//The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600851475143 ?
	public class Problem3
	{
		public void Solve ()
		{
			long answer = 0;
			
			long target = 13195;
			
			List<long> primes = FindPrime(target);
			
			List<long> factors = new List<long>();
			foreach (long item in primes) {
				if(target % item == 0)
					factors.Add(item);
			}
				
			
			long largest = 0;
			foreach (long item in factors) {
				if(item > largest)
					largest = item;
			}
			
			answer = largest;
			
			
			// Get list of all prime numbers
			// For each, does it dive into 13195 by itself and 1.

				
			Console.WriteLine("Answer: " + answer);
		}
		
		public List<long> FindPrime(long target)
		{
			List<long> list = new List<long>();
			
			for(long i = 2; i < target; i++)
			{
			    bool divisible = false;
							
			    foreach(long number in list)
				{
			        if(i % number == 0)
			            divisible = true;
				}
			
			    if(divisible == false)
				{
			        list.Add(i);
				}
			}
			
			
			return list;
		}
	}
}
