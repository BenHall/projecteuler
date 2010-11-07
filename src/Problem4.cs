
using System;
using System.Collections.Generic;

namespace src
{
//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 x 99.

//Find the largest palindrome made from the product of two 3-digit numbers.
	public class Problem4
	{
		public void Solve ()
		{
			string answer = "0";
			
			while(answer == "0")
			{			
				
				for (int i = 999; 100 < i; i--) {
					for (int j = 999; 100 < j; j--) {
						var product = i * j;
						
						string s = product.ToString();
						string r = reversed(s);
						
						if(s == r)
						{
							if(Convert.ToDouble(s) > Convert.ToDouble(answer))
							{
								Console.WriteLine(i + " " + j);
								answer = s;
								break;
							}
						}
					}
				}
			}
				
			Console.WriteLine("Answer: " + answer);
		}
		
		
		public string reversed(string s)
		{
			string result = string.Empty;
		   foreach (char item in s) {
				result = item + result;
		   }	
			
			return result;
		}
	}
}
