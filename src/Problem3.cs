
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
			long max = target / 2;
			long largest = 0;
			
			List<long> primes = FindPrime(max);
			
			List<long> factors = new List<long>();
			foreach (long item in primes) {
				if(target % item == 0)
					factors.Add(item);
			}
				
			
			foreach (long item in factors) {
				if(item > largest)
					largest = item;
			}
	
			answer = largest;
			
						
			Console.WriteLine("Answer: " + answer);
		}
		
		public List<long> FindPrime(long target)
		{
			List<long> primeNumbers = new List<long>();
			
			for(long i = 2; i < target; i++)
			{
			    bool isPrimeNumber = true;
							
			    foreach(long number in primeNumbers)
				{
			        if(i % number == 0)
			            isPrimeNumber = false;
				}
			
			    if(isPrimeNumber)
				{
			        primeNumbers.Add(i);
				}
			}
			
			
			return primeNumbers;
		}
	}
}
