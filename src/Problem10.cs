using System;
using System.Collections;
using System.Collections.Generic;


namespace src
{
// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

// Find the sum of all the primes below two million.
	public class Problem10
	{
		public void Solve ()
		{
			long answer = 0;	
			int target = 2000000;	
		
			var primes = FindPrime(target);
			
			foreach (int item in primes) {
				answer+=item;
			}
			
			Console.WriteLine("Answer: " + answer);
		}
		
		public IEnumerable<int> FindPrime(int target)
		{		
			List<int> possibleValues = new List<int>();
			
			bool[] isPrime = new bool[target + 1];
	        for (int i = 2; i <= target; i++) {
	            isPrime[i] = true;
	        }

			// Only need to process a subset (for 2m = 1414ish)
	        for (int i = 2; i*i <= target; i++) {
	            if (isPrime[i]) { // No need to do anything if it's not even prime
					// Lisewise, only need to process a subset
	                for (int j = i; i*j <= target; j++) {
	                    isPrime[i*j] = false; // Remove all the multiples of i - 2, 3, 5, 7 etc
	                }
	            }
	        }
			
			
			for (int i = 0; i < isPrime.Length; i++) {  // Just return the actual prime numbers
				if(isPrime[i])
					possibleValues.Add(i);
			}
			
			return possibleValues;
		}
	}
}