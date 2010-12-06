using System;
using System.Collections.Generic;


namespace src
{
// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

// What is the 10001st prime number?
	public class Problem7
	{
		public void Solve ()
		{
			int answer = 0;	
			
			int found = 0;
			
			foreach (var item in FindPrime(int.MaxValue)) {
				if(++found == 10001)
				{
					answer = item;
					break;
				}
			}
			
			Console.WriteLine("Answer: " + answer);
		}
		
		public static bool IsPrime(int candidate)
	    {
	        if(candidate == 2)
				return true;
			
	        for (int i = 3; i < candidate; i++)
	        {
	            if ((candidate % i) == 0)
	            {
	                return false;
	            }
	        }
	        return true;
	    }		
		
		public IEnumerable<int> FindPrime(int target)
		{
			List<int> primeNumbers = new List<int>();
			
			for(int i = 2; i < target; i++)
			{
			    bool isPrimeNumber = true;
							
			    foreach(int number in primeNumbers)
				{
			        if(i % number == 0)
			            isPrimeNumber = false;
				}
			
			    if(isPrimeNumber)
				{
			        primeNumbers.Add(i);
					yield return i;
				}
			}
			
		}
	}
}