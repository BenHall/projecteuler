
using System;
using System.Collections.Generic;

namespace src
{
	//Find the greatest product of five consecutive digits in the 1000-digit number.

	public class Problem8
	{
		public void Solve ()
		{
			string target = "73167176531330624919225119674426574742355349194934" +
"96983520312774506326239578318016984801869478851843" +
"85861560789112949495459501737958331952853208805511" +
"12540698747158523863050715693290963295227443043557" +
"66896648950445244523161731856403098711121722383113" +
"62229893423380308135336276614282806444486645238749" +
"30358907296290491560440772390713810515859307960866" +
"70172427121883998797908792274921901699720888093776" +
"65727333001053367881220235421809751254540594752243" +
"52584907711670556013604839586446706324415722155397" +
"53697817977846174064955149290862569321978468622482" +
"83972241375657056057490261407972968652414535100474" +
"82166370484403199890008895243450658541227588666881" +
"16427171479924442928230863465674813919123162824586" +
"17866458359124566529476545682848912883142607690042" +
"24219022671055626321111109370544217506941658960408" +
"07198403850962455444362981230987879927244284909188" +
"84580156166097919133875499200524063689912560717606" +
"05886116467109405077541002256983155200055935729725" +
"71636269561882670428252483600823257530420752963450";
			
			int index = 0;	
			string digits = "";
			int greatest = 0;
			
			while ((index + 5) < target.Length) {
				string digitsBeingTested = target.Substring(index, 5);
							
				int result = 0;
				//for (int i = 1; i < digitsBeingTested.Length; i++) {
				//	result += Convert.ToInt32(digitsBeingTested[i - 1]) * ;
				//}
				
				int[] unsorted = new int[5];
				for (int i = 0; i < digitsBeingTested.Length; i++) {
					int digit = int.Parse(digitsBeingTested[i].ToString());
					unsorted[i] = digit;
				}
				
				
				for (int i = 1; i < unsorted.Length; i++) {
					int valueBeingSorted = unsorted[i];
					int pos = i - 1;
					
					while ((pos >= 0) && (unsorted[pos] > valueBeingSorted)) {
						unsorted[pos + 1] = unsorted[pos];
						pos--;
					}
					
					unsorted[pos + 1] = valueBeingSorted;
				}
				
				result = unsorted[4] * unsorted[3] * unsorted[2] * unsorted[1] * unsorted[0];
				
				
				if(result > greatest)
				{
					greatest = result;
					digits = digitsBeingTested;
				}
					
				
				index++;
			}
				
			
			string answer = digits;
			
			Console.WriteLine("Answer: " + answer);
			Console.WriteLine("Answer: " + greatest);
		}
	}
}
